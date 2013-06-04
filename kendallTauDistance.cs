public int kendallTauDistance(IComparable[] a, IComparable[] x)
        {
            int inversions = 0;

            for (int i = 0; i < a.Length; i++)
            {
                    int a1 = Array.IndexOf(a,a[i]);
                    int a2 = Array.IndexOf(a,a[j]);
                    int x1 = Array.IndexOf(x, a[i]);
                    int x2 = Array.IndexOf(x, a[j]);
                   
                    if (x2 < x1)
                    {

                        if (a[i].CompareTo(x[x2]) != 0)
                        {
                            int temp = x2;
                            x2 = x1;
                            x1 = temp;
                        }
                    }                    
                    
                for (int j = i+1; j < a.Length; j++)
                {
                     if (a[i].CompareTo(a[j]) != x[x1].CompareTo(x[x2]))                    
                        inversions++;                    
                                           
                }
            }

            return inversions;
            
        }
