public int kendallTauDistance(IComparable[] a, IComparable[] b)
        {
            int inversions = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i].CompareTo(a[j]) != b[i].CompareTo(b[j]))                    
                        inversions++;
                                           
                }
            }

            return inversions;
            
        }
