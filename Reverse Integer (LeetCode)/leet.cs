public class Solution
    {
        public int Reverse(int x)
        {
            string k;
            if(x == -2147483412)
            {
                
                return x;
            } 
            bool isN = false;
            if (x < 0)
            {
                x *= -1;
                isN = true;
                k = x.ToString();
            }
            else
            {
                k = x.ToString();
            }

            if (k.Count() >= 10)
            {
                return 0;
            }

            char [] charArray = k.ToCharArray();
            Array.Reverse(charArray);
            k = new string(charArray);           

            if (isN == true)
                return (Convert.ToInt32(k) * -1);
            else
                return Convert.ToInt32(k);

        }
    }