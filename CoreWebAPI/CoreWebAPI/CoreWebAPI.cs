using System;

namespace CoreWebAPI.CoreWebAPI
{
    public class CoreGaming : ICoreGaming
    {

        public bool StartGaming(int num, string guessedValue)
        {
            try
            {
                bool outValue = false;

                if(num%3 == 0 && num%5 == 0)
                {
                    if (String.Compare(guessedValue, "foobar") == 0)
                    { outValue =  true; }
                    else if (num % 3 == 0)
                    {
                        if (String.Compare(guessedValue, "foo") == 0)
                        { outValue = true; }
                        else if (num % 5 == 0)
                        {
                            if (String.Compare(guessedValue, "bar") == 0)
                            { outValue = true; }
                        }
                    }
                    else if (num % 5 == 0)
                    {
                        if (String.Compare(guessedValue, "bar") == 0)
                        { outValue = true; }
                    }
                }

                else if(num % 3 == 0)
                {
                    if (String.Compare(guessedValue, "foo") == 0)
                    { outValue =  true; }
                }
                else if (num % 5 == 0)
                {
                    if (String.Compare(guessedValue, "bar") == 0)
                    { outValue =  true; }
                }
                else
                {
                    if (String.Compare(guessedValue, "none") == 0)
                    { outValue = true; }
                }

                return outValue;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
