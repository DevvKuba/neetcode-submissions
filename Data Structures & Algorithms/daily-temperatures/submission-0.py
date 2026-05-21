class Solution:
    
    def dailyTemperatures(self, temperatures: List[int]) -> List[int]:
        n = len(temperatures)
        result = []

        for i in range(n):
            count = 1
            j = i + 1
            while j < n:
                if temperatures[j] > temperatures[i]:
                    break
                j += 1
                count +=1
            count = 0 if j == n else count # count is 0 if next index == top index of list (n)
            result.append(count)            # else we use count value as normal
        return result




        