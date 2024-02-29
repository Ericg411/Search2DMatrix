public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 1) {
            if (matrix[0].Length == 0) {
                return false;
            }
        }
        for (int i = 0; i < matrix.Length; i++) {
            if (matrix[i][0] == target) {
                return true;
            }
            if (matrix[i][0] < target && matrix[i][matrix[i].Length - 1] > target) {
                Console.WriteLine($"{matrix[i][0]}, {matrix[i][matrix[i].Length - 1]}");
                int left = 0;
                int right = matrix[i].Length - 1;
                while (left <= right) {
                    int mid = left + (right - left) / 2;
                    Console.WriteLine($"{matrix[i][mid]}");
                    if (matrix[i][mid] == target) {
                        return true;
                    } else if (matrix[i][mid] > target) {
                        right = mid - 1;
                    } else {
                        left = mid + 1;
                    }
                }
            } else {
                if (matrix[i][0] == target) {
                    return true;
                }
                if (matrix[i][matrix[i].Length - 1] == target) {
                    return true;
                }
            }
        }
        return false;
    }
}