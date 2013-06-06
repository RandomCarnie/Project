using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//using System.Numerics.BigInteger;
using System.Security.Cryptography;

namespace ConsoleApplication3
{
    public class CSETRSA
    {
        public BigInteger d {get; set;}
        public BigInteger e {get; set;}
        private BigInteger totient;
        public BigInteger n { get; set; }

        public CSETRSA() 
        {
            Init();
        }
        private void Init()
        {
            BigInteger size = new BigInteger(2);
            size = BigInteger.Pow(size, 512);
            size = size - 1;
            BigInteger p = GenerateRandomLargePrime(3, size, 512);
            BigInteger q = GenerateRandomLargePrime(3, size, 512);
            this.n = BigInteger.Multiply(p, q);
            this.totient = ComputeTotient(p, q);
            this.e = ComputeE(this.totient);
            this.d = ComputeD(this.totient, this.e);
        }
        private BigInteger ComputeD(BigInteger totient, BigInteger e)
        {
            CalculateD_2();
            return this.d;
        }
        private BigInteger ComputeE(BigInteger totient)
        {
            BigInteger large_prime = new BigInteger();
            bool isValid = false;
            do
            {
                // Get Large Random Prime
                // Check that it is between 1 and totient
                // Check that gcd(e, totients) == 1
                large_prime = GenerateRandomLargePrime(3, totient > 32000 ? 32000 : totient - 1, 16);
                if (large_prime > 1 && large_prime < totient)
                    if (BigInteger.GreatestCommonDivisor(large_prime, totient) == 1)
                        isValid = true;

            } while (!isValid);

            return large_prime;
        }
        private BigInteger ComputeTotient(BigInteger p, BigInteger q)
        {
            BigInteger p_ret = BigInteger.Subtract(p, 1);
            BigInteger q_ret = BigInteger.Subtract(q, 1);
            return BigInteger.Multiply(p_ret, q_ret);
        }

        public BigInteger EncryptByte(byte plain_text, BigInteger e, BigInteger n)
        {
			return BigInteger.ModPow(plain_text, e, n);
        }
        public BigInteger EncryptByte(byte plain_text)
        {
            return BigInteger.ModPow(plain_text, this.e, this.n);
        }

		public byte DecryptByte(BigInteger cipher_text, BigInteger d, BigInteger n)
        {
			return BigInteger.ModPow(cipher_text, d, n).ToByteArray()[0];
        }
        public byte DecryptByte(BigInteger cipher_text)
        {
            BigInteger ret = BigInteger.ModPow(cipher_text, this.d, this.n);
                //BigInteger.ModPow(cipher_text, this.d, this.n).ToByteArray()[0];
            return ret.ToByteArray()[0];
        }

        
        private bool IsProbablePrime(BigInteger source, int certainty)
        {
            if (source == 2 || source == 3)
                return true;
            if (source < 2 || source % 2 == 0)
                return false;

            BigInteger d = source - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }

            // There is no built-in method for generating random BigInteger values.
            // Instead, random BigIntegers are constructed from randomly generated
            // byte arrays of the same length as the source.
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[source.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    // This may raise an exception in Mono 2.10.8 and earlier.
                    // http://bugzilla.xamarin.com/show_bug.cgi?id=2761
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= source - 2);

                BigInteger x = BigInteger.ModPow(a, d, source);
                if (x == 1 || x == source - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1)
                        return false;
                    if (x == source - 1)
                        break;
                }

                if (x != source - 1)
                    return false;
            }

            return true;
        }
		// size is size in bits 
        private BigInteger GenerateRandomLargePrime(BigInteger min, BigInteger max, uint size)
        {
            bool IsPrime = false;
            BigInteger p = new BigInteger();
            do
            {
                var rng = new RNGCryptoServiceProvider();
                byte[] bytes = new byte[size / 8];
                do
                {
                    rng.GetBytes(bytes);
                    p = new BigInteger(bytes);
                    if (p < 0)
                    {
                        p = BigInteger.Negate(p);
                    }
                }
                while (0 > p.CompareTo(min) || 0 < p.CompareTo(max));

                if (IsProbablePrime(p, 100))
                    IsPrime = true;
            } while (!IsPrime);

            return p;
        }
        private void CalculateD_2()
        {
            //this.d = (Extended_GDC(this.eC, this.phi, true))[1];
            this.d = (Extended_GDC(this.e, this.totient, true))[1];
        }

        /// <summary>
        /// This method implements the extended euclidian GDC algorithm and the modulo inverse algorithm
        /// </summary>
        /// <param name="a">The number for which to apply the chosen algorithm</param>
        /// <param name="modulus">The modulus</param>
        /// <param name="calcOnlyModuloInverse">If = true, then modulo inverse algorithm will be applied, else EEGCD</param>
        /// <returns>array[3]. In the case of EEGCD: array[0] = multiplicative inverse of a to modulus
        /// array[1] = multiplicative inverse of modulus to a
        /// array[2] = the GCD
        /// 
        /// so that array[2] = a*array[0] + modulus*array[1];
        /// 
        /// In the case of modulo inverse algorithm: array[0] == array[2] = 0; array[1] = positive modulo inverse of a to modulus.
        /// This is the difference from the EEGCD algorithm, which can return negative. This one is used for RSA
        /// </returns>
        private BigInteger[] Extended_GDC(BigInteger a, BigInteger modulus, Boolean calcOnlyModuloInverse)
        {
            BigInteger x, lastX, b_, y, lastY, a_, quotient, temp, temp2, temp3;
            BigInteger[] result;

            if (modulus == 0) return new BigInteger[] { 1, 0, a };

            // We assure ourselves that the two algorithms below will give good results in any case
            if (a < modulus)
            {
                x = 0; lastX = 1; b_ = modulus;
                y = 1; lastY = 0; a_ = a;
            }
            else
            {
                x = 1; lastX = 0; b_ = a;
                y = 0; lastY = 1; a_ = modulus;
            }

            if (calcOnlyModuloInverse)
            {
                // modulo inverse calculation
                // http://snippets.dzone.com/posts/show/4256
                while (a_ > 0)
                {
                    temp = a_;
                    quotient = b_ / a_;     // If not BigInteger used, then use direct cast to Int32

                    a_ = b_ % temp;
                    b_ = temp;
                    temp = y;

                    y = lastY - quotient * temp;
                    lastY = temp;
                }

                lastY %= modulus;

                if (lastY < 0) lastY = (lastY + modulus) % modulus;
                result = new BigInteger[] { 0, lastY, 0 };
            }
            else
            {
                // Extended euclidian algorithm
                // http://everything2.com/title/Extended+Euclidean+algorithm
                // The only good implementation of the full Extended Euclidian Algorithm that I found
                while (a_ > 1)
                {
                    quotient = b_ / a_;     // If not BigInteger used, then use direct cast to Int32
                    temp = x - quotient * y;
                    temp2 = lastX - quotient * lastY;
                    temp3 = b_ - quotient * a_;

                    x = y; lastX = lastY; b_ = a_;
                    y = temp; lastY = temp2; a_ = temp3;
                }

                if (a_ == 0) result = new BigInteger[] { x, lastX, b_ };
                else result = new BigInteger[] { y, lastY, a_ };
            }

            return result;
        }

    }
}

