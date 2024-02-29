impl Solution {
    pub fn search_matrix(matrix: Vec<Vec<i32>>, target: i32) -> bool {
        if matrix.is_empty() || matrix[0].is_empty() {
            return false;
        }

        let m: i32 = matrix.len() as i32;
        let n: i32 = matrix[0].len() as i32;
        let mut left: i32 = 0;
        let mut right: i32 = (m * n) - 1;

        while left <= right {
            let mid: i32 = left + (right - left) / 2;
            let row: i32 = mid / n;
            let col: i32 = mid % n;

            if matrix[row as usize][col as usize] == target {
                return true;
            } else if matrix[row as usize][col as usize] > target {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }

        false
    }
}