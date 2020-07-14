public class User
    {
        public int progress { get; set; }
        public int rank { get; set; }

        public User()
        {
            progress = 0;
            rank = -8;
        }
        public void incProgress(int value)
        {
            if (verifyRank8() == false)
            {
                if (value < -8 || value > 8 || value == 0)
                {
                    throw new System.ArgumentException();
                }
                int[] rankings = { -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8 };
                int PositionValue = 0;
                int ActualPosition = 0;
                for (int i = 0; i < rankings.Length; i++)
                {
                    if (rankings[i] == value)
                    {
                        PositionValue = i;
                    }
                    if (rankings[i] == rank)
                    {
                        ActualPosition = i;
                    }
                }
                if (PositionValue == ActualPosition)
                {
                    progress += 3;
                }
                else if (PositionValue == ActualPosition - 1)
                {
                    progress += 1;
                }
                int dif = 0;
                if (PositionValue >= ActualPosition)
                {
                    dif = PositionValue - ActualPosition;
                    progress += (10 * dif * dif);
                }

                this.attRanking(dif, ActualPosition);
            }
        }
        public void attRanking(int dif, int ActualPosition)
        {
          
                if (progress >= 100)
                {
                    int ranksup = 0;
                    while (progress >= 100)
                    {
                        progress -= 100;
                        ranksup++;
                    }

                    for (int i = 1; i <= ranksup; i++)
                    {
                        if (rank == 8)
                        {
                            progress = 0;
                            break;
                        }
                        if (rank == 0)
                        {
                            rank = 1;
                        }
                        rank++;
                        if (rank == 0)
                        {
                            rank = 1;
                        }
                    }
                    if (rank == 8)
                    {
                        progress = 0;
                    }
                }
            
        }
        public bool verifyRank8()
        {
            if (this.rank == 8)
            {
                progress = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

    }