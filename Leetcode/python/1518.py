class Solution:
    def numWaterBottles(self, numBottles: int, numExchange: int) -> int:
        if numBottles < numExchange:
            return numBottles

        res, emptyBottles = numBottles, numBottles

        while emptyBottles >= numExchange:
            newFullBottles = emptyBottles // numExchange
            res += newFullBottles

            newEmptyBottles = newFullBottles
            emptyBottles = emptyBottles % numExchange + newEmptyBottles
        
        return res