using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Hashtool
{
    public enum HashAlgType
    {
      SM3,SHA2_256,SHA2_384,SHA2_512,SHA3_256,SHA3_384,SHA3_512
    }

    public static class HashAlgHandler
    {
        /// <summary>
        /// 該回方法的名稱
        /// </summary>
        public static string GetName(HashAlgType algType)
        {
            switch (algType)
            {
                case HashAlgType.SM3:
                    return "SM3";
                case HashAlgType.SHA2_256:
                    return "SHA256";
                case HashAlgType.SHA2_384:
                    return "SHA384";
                case HashAlgType.SHA2_512:
                    return "SHA512";
                case HashAlgType.SHA3_256:
                    return "SHA3-256";
                case HashAlgType.SHA3_384:
                    return "SHA3-384";
                case HashAlgType.SHA3_512:
                    return "SHA3-512";
           
               
               
                
                default:
                    throw new ArgumentException("Unknown HashAlgType.");
            }
        }

        /// <summary>
        /// 获得哈希算法计算对象
        /// </summary>
        public static HashAlgorithm GetHashObj(HashAlgType algType)
        {
            switch (algType)
            {
                case HashAlgType.SM3:
                    return new SM3();
                case HashAlgType.SHA2_256:
                    return SHA256.Create();
                case HashAlgType.SHA2_384:
                    return SHA384.Create();
                case HashAlgType.SHA2_512:
                    return SHA512.Create();
                case HashAlgType.SHA3_256:
                    return new SHA3_256();
                case HashAlgType.SHA3_384:
                    return new SHA3_384();
                case HashAlgType.SHA3_512:
                    return new SHA3_512();
               

              
                
                default:
                    throw new ArgumentException("Unknown HashAlgType.");
            }
        }
    }

    public abstract partial class SHA3Base
    {
        // 常量
        //protected const int b = 1600;
        //protected const int w = 64;
        //protected const int l = 6;

        private static int[] laneOffset = new int[25] {
               0,   1, 190,  28,  91,
              36, 300,   6,  55, 276,
               3,  10, 171, 153, 231,
             105,  45,  15,  21, 136,
             210,  66, 253, 120,  78,
        };

        private static ulong[] RC_table = new ulong[24]
        {
            0x0000000000000001,
            0x0000000000008082,
            0x800000000000808a,
            0x8000000080008000,
            0x000000000000808b,
            0x0000000080000001,
            0x8000000080008081,
            0x8000000000008009,
            0x000000000000008a,
            0x0000000000000088,
            0x0000000080008009,
            0x000000008000000a,
            0x000000008000808b,
            0x800000000000008b,
            0x8000000000008089,
            0x8000000000008003,
            0x8000000000008002,
            0x8000000000000080,
            0x000000000000800a,
            0x800000008000000a,
            0x8000000080008081,
            0x8000000000008080,
            0x0000000080000001,
            0x8000000080008008
        };

        // 放置顺序是先 x 后 y, 64 bit 小端存储
        // (0, 0) -> (0, 1) -> ... (y, x) -> (y, x + 1) -> (4, 4)
        private ulong[] state = new ulong[25];

        private static void PreCompRCtable()
        {
            ulong rc(int t)
            {
                ulong R = 0x01;
                if (t % 255 != 0)
                {
                    for (int i = 0; i < t % 255; i++)
                    {
                        R <<= 1;
                        R ^= ((R >> 8) & 0x01u) | ((R >> 4) & 0x10u) | ((R >> 3) & 0x20u) | ((R >> 2) & 0x40u);
                        R &= 0xffu;
                    }
                }
                return R & 0x01u;
            }
            for (int i = 0; i < 24; i++)
            {
                ulong RC = 0x00;
                for (int j = 0; j <= 6; j++)
                {
                    RC |= rc(j + (7 * i)) << ((1 << j) - 1);
                }
                RC_table[i] = RC;
            }
        }

        /// <summary>
        /// 循环左移
        /// </summary>
        /// <param name="X"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        private static ulong ROL(ulong X, int count)
        {
            // C# 里移位运算符自动模数值长度, 所以不需要对 count 进行处理
            // 当 count 为 0 或 64 时, 左右两半都没移位, 因此只能用或运算符进行连接
            return (X << count) | (X >> (-count));
        }

        #region Keccak 的 5 个 Step Mappings 函数

        private ulong[] C = new ulong[5];
        private ulong[] D = new ulong[5];
        private void Theta()
        {
            // 把 5 个 Plane 压缩成 C
            //for (int x = 0; x < 5; x++)
            //{
            //    C[x] = state[0 * 5 + x] ^ state[1 * 5 + x] ^ state[2 * 5 + x] ^ state[3 * 5 + x] ^ state[4 * 5 + x];
            //}
            C[0] = state[0] ^ state[5] ^ state[10] ^ state[15] ^ state[20];
            C[1] = state[1] ^ state[6] ^ state[11] ^ state[16] ^ state[21];
            C[2] = state[2] ^ state[7] ^ state[12] ^ state[17] ^ state[22];
            C[3] = state[3] ^ state[8] ^ state[13] ^ state[18] ^ state[23];
            C[4] = state[4] ^ state[9] ^ state[14] ^ state[19] ^ state[24];

            // 对 C 混合产生 D
            D[0] = C[4] ^ ROL(C[1], 1);
            D[1] = C[0] ^ ROL(C[2], 1);
            D[2] = C[1] ^ ROL(C[3], 1);
            D[3] = C[2] ^ ROL(C[4], 1);
            D[4] = C[3] ^ ROL(C[0], 1);

            // 对每一个 Plane[i] 用 D 异或一次
            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 5; x++)
            //    {
            //        state[y * 5 + x] ^= D[x];
            //    }
            //}
            state[0] ^= D[0];
            state[1] ^= D[1];
            state[2] ^= D[2];
            state[3] ^= D[3];
            state[4] ^= D[4];

            state[5] ^= D[0];
            state[6] ^= D[1];
            state[7] ^= D[2];
            state[8] ^= D[3];
            state[9] ^= D[4];

            state[10] ^= D[0];
            state[11] ^= D[1];
            state[12] ^= D[2];
            state[13] ^= D[3];
            state[14] ^= D[4];

            state[15] ^= D[0];
            state[16] ^= D[1];
            state[17] ^= D[2];
            state[18] ^= D[3];
            state[19] ^= D[4];

            state[20] ^= D[0];
            state[21] ^= D[1];
            state[22] ^= D[2];
            state[23] ^= D[3];
            state[24] ^= D[4];
        }

        private void Rho()
        {
            //for (int i = 0; i < 25; i++)
            //{
            //    state[i] = ROL(state[i], laneOffset[i]);
            //}
            state[0] = ROL(state[0], 0);
            state[1] = ROL(state[1], 1);
            state[2] = ROL(state[2], 190);
            state[3] = ROL(state[3], 28);
            state[4] = ROL(state[4], 91);
            state[5] = ROL(state[5], 36);
            state[6] = ROL(state[6], 300);
            state[7] = ROL(state[7], 6);
            state[8] = ROL(state[8], 55);
            state[9] = ROL(state[9], 276);
            state[10] = ROL(state[10], 3);
            state[11] = ROL(state[11], 10);
            state[12] = ROL(state[12], 171);
            state[13] = ROL(state[13], 153);
            state[14] = ROL(state[14], 231);
            state[15] = ROL(state[15], 105);
            state[16] = ROL(state[16], 45);
            state[17] = ROL(state[17], 15);
            state[18] = ROL(state[18], 21);
            state[19] = ROL(state[19], 136);
            state[20] = ROL(state[20], 210);
            state[21] = ROL(state[21], 66);
            state[22] = ROL(state[22], 253);
            state[23] = ROL(state[23], 120);
            state[24] = ROL(state[24], 78);
        }

        private void Pi()
        {
            ulong tmp = state[18];
            state[18] = state[17];
            state[17] = state[11];
            state[11] = state[7];
            state[7] = state[10];
            state[10] = state[1];
            state[1] = state[6];
            state[6] = state[9];
            state[9] = state[22];
            state[22] = state[14];
            state[14] = state[20];
            state[20] = state[2];
            state[2] = state[12];
            state[12] = state[13];
            state[13] = state[19];
            state[19] = state[23];
            state[23] = state[15];
            state[15] = state[4];
            state[4] = state[24];
            state[24] = state[21];
            state[21] = state[8];
            state[8] = state[16];
            state[16] = state[5];
            state[5] = state[3];
            state[3] = tmp;
        }

        private void Chi()
        {
            ulong tmp1, tmp2;
            //for (int y = 0; y < 5; y++)
            //{
            //    tmp1 = state[y * 5 + 0];
            //    tmp2 = state[y * 5 + 1];
            //    state[y * 5 + 0] ^= ~state[y * 5 + 1] & state[y * 5 + 2];
            //    state[y * 5 + 1] ^= ~state[y * 5 + 2] & state[y * 5 + 3];
            //    state[y * 5 + 2] ^= ~state[y * 5 + 3] & state[y * 5 + 4];
            //    state[y * 5 + 3] ^= ~state[y * 5 + 4] & tmp1;
            //    state[y * 5 + 4] ^= ~tmp1 & tmp2;
            //}
            tmp1 = state[0];
            tmp2 = state[1];
            state[0] ^= ~state[1] & state[2];
            state[1] ^= ~state[2] & state[3];
            state[2] ^= ~state[3] & state[4];
            state[3] ^= ~state[4] & tmp1;
            state[4] ^= ~tmp1 & tmp2;

            tmp1 = state[5];
            tmp2 = state[6];
            state[5] ^= ~state[6] & state[7];
            state[6] ^= ~state[7] & state[8];
            state[7] ^= ~state[8] & state[9];
            state[8] ^= ~state[9] & tmp1;
            state[9] ^= ~tmp1 & tmp2;

            tmp1 = state[10];
            tmp2 = state[11];
            state[10] ^= ~state[11] & state[12];
            state[11] ^= ~state[12] & state[13];
            state[12] ^= ~state[13] & state[14];
            state[13] ^= ~state[14] & tmp1;
            state[14] ^= ~tmp1 & tmp2;

            tmp1 = state[15];
            tmp2 = state[16];
            state[15] ^= ~state[16] & state[17];
            state[16] ^= ~state[17] & state[18];
            state[17] ^= ~state[18] & state[19];
            state[18] ^= ~state[19] & tmp1;
            state[19] ^= ~tmp1 & tmp2;

            tmp1 = state[20];
            tmp2 = state[21];
            state[20] ^= ~state[21] & state[22];
            state[21] ^= ~state[22] & state[23];
            state[22] ^= ~state[23] & state[24];
            state[23] ^= ~state[24] & tmp1;
            state[24] ^= ~tmp1 & tmp2;
        }

        private void Iota(int roundIndex)
        {
            state[0] ^= RC_table[roundIndex];
        }

        #endregion

        // Keccak-p[1600, 24]
        private void Keccak_p_1600_24()
        {
            for (int i = 0; i < 24; i++)
            {
                Theta();
                Rho();
                Pi();
                Chi();
                Iota(i);
            }
        }
    }

    public abstract partial class SHA3Base : HashAlgorithm
    {
        private byte[] dataBuffer;
        private int dataBufferLen = 0; // 最大长度为 rSize

        private int dSize;
        private int cSize { get { return 2 * dSize; } }
        private int rSize { get { return 200 - cSize; } }
        
        public SHA3Base(int d)
        {
            dSize = d / 8;
            dataBuffer = new byte[rSize];
        }

        /// <summary>
        /// 填充 blockBuffer
        /// </summary>
        /// <param name="data"></param>
        /// <param name="dataStart"></param>
        private void ReadBlock(byte[] data, int dataStart = 0)
        {
            // 按小端序读取数据
            for (int i = 0; i < rSize / 8; i++)
            {
                state[i] ^= ((ulong)data[dataStart + i * 8 + 7] << 56)
                          | ((ulong)data[dataStart + i * 8 + 6] << 48)
                          | ((ulong)data[dataStart + i * 8 + 5] << 40)
                          | ((ulong)data[dataStart + i * 8 + 4] << 32)
                          | ((ulong)data[dataStart + i * 8 + 3] << 24)
                          | ((ulong)data[dataStart + i * 8 + 2] << 16)
                          | ((ulong)data[dataStart + i * 8 + 1] <<  8)
                          | ((ulong)data[dataStart + i * 8    ]      );
            }

            // 剩余的 cSize 部分全部是 0x00 填充, 所以 state 异或之后不变
            //for (int i = rSize / 8; i < 25; i++)
            //{
            //    state[i] ^= 0x00u;
            //}
        }

        public override void Initialize()
        {
            for(int i = 0; i < 25; i++)
            {
                state[i] = 0;
            }

            dataBufferLen = 0;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            if (cbSize + dataBufferLen >= rSize)
            {
                int readPos = ibStart;

                // 处理上一次缓冲区剩余的数据
                Array.Copy(array, 0, dataBuffer, dataBufferLen, rSize - dataBufferLen);
                readPos += rSize - dataBufferLen;
                ReadBlock(dataBuffer);
                Keccak_p_1600_24();

                // 按每 rSize 个字节来读取数据
                while (readPos + rSize < ibStart + cbSize)
                {
                    ReadBlock(array, ibStart + readPos);
                    readPos += rSize;
                    Keccak_p_1600_24();
                }

                // 保留本次剩余数据
                Array.Copy(array, ibStart + readPos, dataBuffer, 0, cbSize - (readPos - ibStart));
                dataBufferLen = cbSize - (readPos - ibStart);
            }
            else
            {
                // 向缓冲区增加保留数据
                Array.Copy(array, ibStart, dataBuffer, dataBufferLen, cbSize);
                dataBufferLen += cbSize;
            }
        }

        protected override byte[] HashFinal()
        {
            byte[] hashValue = new byte[dSize];

            // 尾块填充
            if (dataBufferLen == rSize - 1)
            {
                dataBuffer[rSize - 1] = 0x86;
            }
            else
            {
                dataBuffer[dataBufferLen++] = 0x06;
                for(int i = dataBufferLen; i < rSize - 1; i++)
                {
                    dataBuffer[i] = 0x00;
                }
                dataBuffer[rSize - 1] = 0x80;
            }

            ReadBlock(dataBuffer);
            Keccak_p_1600_24();

            // SHA3 算法的 r 一定大于 d, 所以没有实际挤压过程
            for (int i = 0; i < dSize / 8; i++)
            {
                hashValue[i * 8    ] = (byte)(state[i]      );
                hashValue[i * 8 + 1] = (byte)(state[i] >>  8);
                hashValue[i * 8 + 2] = (byte)(state[i] >> 16);
                hashValue[i * 8 + 3] = (byte)(state[i] >> 24);
                hashValue[i * 8 + 4] = (byte)(state[i] >> 32);
                hashValue[i * 8 + 5] = (byte)(state[i] >> 40);
                hashValue[i * 8 + 6] = (byte)(state[i] >> 48);
                hashValue[i * 8 + 7] = (byte)(state[i] >> 56);
            }
            return hashValue;
        }
    }

    public class SHA3_256 : SHA3Base
    {
        public SHA3_256() : base(256) { }
    }

    public class SHA3_512 : SHA3Base
    {
        public SHA3_512() : base(512) { }
    }
    //新加的方法
    public class SHA3_384 : SHA3Base
    {
        public SHA3_384() : base(384) { }
    }


    public class SM3 : HashAlgorithm
    {
        private static uint[] ROL_T_table = new uint[64] {
            0x79cc4519, 0xf3988a32, 0xe7311465, 0xce6228cb, 0x9cc45197, 0x3988a32f, 0x7311465e, 0xe6228cbc,
            0xcc451979, 0x988a32f3, 0x311465e7, 0x6228cbce, 0xc451979c, 0x88a32f39, 0x11465e73, 0x228cbce6,
            0x9d8a7a87, 0x3b14f50f, 0x7629ea1e, 0xec53d43c, 0xd8a7a879, 0xb14f50f3, 0x629ea1e7, 0xc53d43ce,
            0x8a7a879d, 0x14f50f3b, 0x29ea1e76, 0x53d43cec, 0xa7a879d8, 0x4f50f3b1, 0x9ea1e762, 0x3d43cec5,
            0x7a879d8a, 0xf50f3b14, 0xea1e7629, 0xd43cec53, 0xa879d8a7, 0x50f3b14f, 0xa1e7629e, 0x43cec53d,
            0x879d8a7a, 0x0f3b14f5, 0x1e7629ea, 0x3cec53d4, 0x79d8a7a8, 0xf3b14f50, 0xe7629ea1, 0xcec53d43,
            0x9d8a7a87, 0x3b14f50f, 0x7629ea1e, 0xec53d43c, 0xd8a7a879, 0xb14f50f3, 0x629ea1e7, 0xc53d43ce,
            0x8a7a879d, 0x14f50f3b, 0x29ea1e76, 0x53d43cec, 0xa7a879d8, 0x4f50f3b1, 0x9ea1e762, 0x3d43cec5,
        };

        /// <summary>
        /// 预计算 ROL(T(j), j)
        /// </summary>
        private static void PreCompROLTtable()
        {
            for (int j = 0; j < 64; j++)
            {
                ROL_T_table[j] = ROL(T(j), j);
            }
        }

        private uint[] sm3HashValue = new uint[8];
        private ulong msgLength = 0; // 数据最大长度为 2 的 64 次方 bit

        private byte[] dataBuffer = new byte[64];
        private int dataBufferLen = 0;

        private uint[] wordsBuffer1 = new uint[68];
        private uint[] wordsBuffer2 = new uint[64];
        
        #region 静态辅助方法

        private static uint T(int j)
        {
            return j <= 15 ? 0x79cc4519u : 0x7a879d8au;
        }

        private static uint FF(int j, uint X, uint Y, uint Z)
        {
            return j <= 15 ? (X ^ Y ^ Z) : ((X & Y) | (X & Z) | (Y & Z));
        }

        private static uint GG(int j, uint X, uint Y, uint Z)
        {
            return j <= 15 ? (X ^ Y ^ Z) : ((X & Y) | (~X & Z));
        }

        private static uint ROL(uint X, int count)
        {
            // C# 里移位运算符自动模数值长度, 所以不需要对 count 进行处理
            // 当 count 为 0 或 32 时, 左右两半都没移位, 因此只能用或运算符进行连接
            return (X << count) | (X >> (-count));
        }

        private static uint P0(uint X)
        {
            return X ^ ROL(X, 9) ^ ROL(X, 17);
        }

        private static uint P1(uint X)
        {
            return X ^ ROL(X, 15) ^ ROL(X, 23);
        }

        #endregion

        /// <summary>
        /// 扩展函数, 把 512 bit 的 16 个字扩展成 132 个字
        /// </summary>
        private void Expand()
        {
            for (int j = 16; j < 68; j++)
            {
                wordsBuffer1[j] = P1(wordsBuffer1[j - 16] ^ wordsBuffer1[j - 9] ^ ROL(wordsBuffer1[j - 3], 15))
                                ^ ROL(wordsBuffer1[j - 13], 7)
                                ^ wordsBuffer1[j - 6];
            }
            for (int j = 0; j < 64; j++)
            {
                wordsBuffer2[j] = wordsBuffer1[j] ^ wordsBuffer1[j + 4];
            }
        }

        /// <summary>
        /// 压缩函数, 每次接收 16 个 32 bit 字的数据进行压缩, 会更新 sm3HashValue 的值
        /// </summary>
        /// <param name="data"></param>
        private void CF()
        {
            Expand();

            uint A = sm3HashValue[0];
            uint B = sm3HashValue[1];
            uint C = sm3HashValue[2];
            uint D = sm3HashValue[3];
            uint E = sm3HashValue[4];
            uint F = sm3HashValue[5];
            uint G = sm3HashValue[6];
            uint H = sm3HashValue[7];
            uint SS1, SS2, TT1, TT2;

            for (int j = 0; j < 64; j++)
            {
                //SS1 = ROL(ROL(A, 12) + E + ROL(T(j), j), 7);
                SS1 = ROL(ROL(A, 12) + E + ROL_T_table[j], 7);
                SS2 = SS1 ^ ROL(A, 12);
                TT1 = FF(j, A, B, C) + D + SS2 + wordsBuffer2[j];
                TT2 = GG(j, E, F, G) + H + SS1 + wordsBuffer1[j];
                D = C;
                C = ROL(B, 9);
                B = A;
                A = TT1;
                H = G;
                G = ROL(F, 19);
                F = E;
                E = P0(TT2);
            }

            sm3HashValue[0] = A ^ sm3HashValue[0];
            sm3HashValue[1] = B ^ sm3HashValue[1];
            sm3HashValue[2] = C ^ sm3HashValue[2];
            sm3HashValue[3] = D ^ sm3HashValue[3];
            sm3HashValue[4] = E ^ sm3HashValue[4];
            sm3HashValue[5] = F ^ sm3HashValue[5];
            sm3HashValue[6] = G ^ sm3HashValue[6];
            sm3HashValue[7] = H ^ sm3HashValue[7];
        }

        /// <summary>
        /// 读取 64 字节数据进入待计算缓冲区
        /// </summary>
        /// <param name="data"></param>
        /// <param name="dataStart"></param>
        /// <returns></returns>
        private void ReadBlock(byte[] data, int dataStart = 0)
        {
            for (int i = 0; i < 16; i++)
            {
                wordsBuffer1[i] = ((uint)data[dataStart + i * 4    ] << 24)
                                | ((uint)data[dataStart + i * 4 + 1] << 16)
                                | ((uint)data[dataStart + i * 4 + 2] <<  8)
                                | ((uint)data[dataStart + i * 4 + 3]      );
            }
        }

        public override void Initialize()
        {
            //PreCompROLTtable();
            // 初始向量
            sm3HashValue[0] = 0x7380166fu;
            sm3HashValue[1] = 0x4914b2b9u;
            sm3HashValue[2] = 0x172442d7u;
            sm3HashValue[3] = 0xda8a0600u;
            sm3HashValue[4] = 0xa96f30bcu;
            sm3HashValue[5] = 0x163138aau;
            sm3HashValue[6] = 0xe38dee4du;
            sm3HashValue[7] = 0xb0fb0e4eu;

            msgLength = 0;

            dataBufferLen = 0;
        }

        protected override void HashCore(byte[] array, int ibStart, int cbSize)
        {
            if (cbSize + dataBufferLen >= 64)
            {
                int readPos = ibStart;

                // 处理上一次缓冲区剩余的数据
                Array.Copy(array, 0, dataBuffer, dataBufferLen, 64 - dataBufferLen);
                readPos += 64 - dataBufferLen;
                ReadBlock(dataBuffer);
                CF();

                // 按每 64 个字节来读取数据
                while (readPos + 64 < ibStart + cbSize)
                {
                    ReadBlock(array, ibStart + readPos);
                    readPos += 64;
                    CF();
                }

                // 保留本次剩余数据
                Array.Copy(array, ibStart + readPos, dataBuffer, 0, cbSize - (readPos - ibStart));
                dataBufferLen = cbSize - (readPos - ibStart);
            }
            else
            {
                // 向缓冲区增加保留数据
                Array.Copy(array, ibStart, dataBuffer, dataBufferLen, cbSize);
                dataBufferLen += cbSize;
            }

            if (msgLength * 8 > (msgLength + (ulong)cbSize) * 8)
            {
                throw new OverflowException("Data too long.");
            }
            msgLength += (ulong)cbSize;
        }

        protected override byte[] HashFinal()
        {
            byte[] hashValue = new byte[32];

            // 尾部填充
            dataBuffer[dataBufferLen] = 0x80;
            for (int i = dataBufferLen + 1; i < 56; i++)
            {
                dataBuffer[i] = 0x00;
            }
            ulong msgBitLen = msgLength * 8;
            dataBuffer[56] = (byte)(msgBitLen >> 56);
            dataBuffer[57] = (byte)(msgBitLen >> 48);
            dataBuffer[58] = (byte)(msgBitLen >> 40);
            dataBuffer[59] = (byte)(msgBitLen >> 32);
            dataBuffer[60] = (byte)(msgBitLen >> 24);
            dataBuffer[61] = (byte)(msgBitLen >> 16);
            dataBuffer[62] = (byte)(msgBitLen >>  8);
            dataBuffer[63] = (byte)(msgBitLen      );

            ReadBlock(dataBuffer);
            CF();

            for (int i = 0; i < 8; i++)
            {
                hashValue[i * 4    ] = (byte)(sm3HashValue[i] >> 24);
                hashValue[i * 4 + 1] = (byte)(sm3HashValue[i] >> 16);
                hashValue[i * 4 + 2] = (byte)(sm3HashValue[i] >>  8);
                hashValue[i * 4 + 3] = (byte)(sm3HashValue[i]      );
            }
            return hashValue;
        }
    }

    
}
