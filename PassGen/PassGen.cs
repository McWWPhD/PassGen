using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace PassGen
{
    class PassGen
    {
        Random random = new Random((int)DateTime.Now.Ticks);

        public string GenNum(int length)
        {
            StringBuilder pass = new StringBuilder();
            
            for (int i = 0; i < length; i++)
            {
                pass.Append(random.Next(0, 10));
            }

            return Convert.ToString(pass);
        }

        public string GenNumLett(int length)
        {

            StringBuilder pass = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                int _case = random.Next(1, 4);

                switch (_case)
                {
                    case 1:

                        pass.Append(random.Next(0, 10));
                        break;

                    case 2:

                        pass.Append((char)random.Next(65, 91));
                        break;

                    case 3:

                        pass.Append((char)random.Next(97, 123));
                        break;

                    default:
                        break;

                }

            }
            return Convert.ToString(pass);
        }

        public string GenNumLettSpec (int length)
        {
            StringBuilder pass = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                pass.Append((char)random.Next(33, 127));

            }

            return Convert.ToString(pass);

        }


    }

}
