from statistics import mean
from typing import List


class Solution:
    def carFleet(self, target: int, position: List[int], speed: List[int]) -> int:

        car_fleets = 0
        car_list = []
        destination_times = []


        for p in range(len(position)):
            car_list.append((position[p], speed[p]))

        car_list.sort(reverse=True)

        for car in car_list:
            destination_time = (target - car[0]) / car[1]
            if destination_time not in destination_times:
                destination_times.append(destination_time)
                try:
                    if destination_time < max(destination_times):
                        car_fleets -= 1
                except:
                    pass

        car_fleets += len(destination_times)
        return car_fleets





        # while mean(position) < target:
        #
        #     for p in range(len(position)):
        #         position[p] += speed[p]
        #
        # return position

# target = 10
# position = [0, 4, 2]
# speed = [2,1,3]

target=12
position=[10,8,0,5,3]
speed=[2,4,1,1,3]

solution = Solution()
print(solution.carFleet(target, position, speed))