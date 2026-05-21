class Solution:
    
    def productExceptSelf(self, arr: List[int]) -> List[int]:
        prod_arr = []
        for i in range(len(arr)):
            prod = 0
            temp = arr.pop(i)
            for j in range(len(arr)):
                if j == 0:
                    prod += arr[j]
                else:
                    prod = prod * arr[j]
            prod_arr.append(prod)
            arr.insert(i, temp)
        return prod_arr



        