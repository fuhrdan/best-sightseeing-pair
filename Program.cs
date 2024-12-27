//*****************************************************************************
//** 1014. Best Sightseeing Pair                                    leetcode **
//*****************************************************************************


int maxScoreSightseeingPair(int* values, int valuesSize) {
    int ans = 0;
    int mx = values[0];
    
    for (int j = 1; j < valuesSize; ++j)
    {
        if (ans < values[j] - j + mx)
        {
            ans = values[j] - j + mx;
        }
        
        if (mx < values[j] + j)
        {
            mx = values[j] + j;
        }
    }
    
    return ans;
}