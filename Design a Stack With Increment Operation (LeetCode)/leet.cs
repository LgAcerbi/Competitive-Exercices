public class CustomStack
    {

        public int[] myStack;
        public int count;
        public CustomStack(int maxSize)
        {
            myStack = new int[maxSize];
            count = 0;
        }

        public void Push(int x)
        {
            if (count < myStack.Length)
            {
                count++;
                for (int i = 0; i < myStack.Length; i++)
                {
                    if(myStack[i] == 0)
                    {
                        myStack[i] = x;
                        break;
                    }
                }
            }
        }

        public int Pop()
        {
            if (myStack[0] == 0)
            {
                return -1;
            }
            else
            {
                int valor = 0;
                for (int i = 0; i < myStack.Length + 1; i++)
                {
                    if(i == myStack.Length)
                    {
                        valor = myStack[i - 1];
                        myStack[i - 1] = 0;
                        break;
                    }
                    if(myStack[i] == 0)
                    {
                        valor = myStack[i - 1];
                        myStack[i - 1] = 0;
                        break;
                    }
                }
                count--;
                return valor;
            }
        }

        public void Increment(int k, int val)
        {
            if (!(myStack[0] == 0))
            {
                if (myStack.Length < k)
                {
                    for (int j = 0; j < myStack.Length; j++)
                    {
                        if (myStack[j] != 0)
                        {
                            myStack[j] += val;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < k; i++)
                    {
                        if (myStack[i] != 0)
                        {
                            if (i == myStack.Length)
                            {
                                break;
                            }
                            myStack[i] += val;
                        }
                    }
                }
            }
        }
    }