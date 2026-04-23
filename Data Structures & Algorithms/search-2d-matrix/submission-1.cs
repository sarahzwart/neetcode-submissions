public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // 
        int rows = matrix.Length, cols = matrix[0].Length;
        int l = 0, r = rows * cols - 1;
        while(l <= r ){
            int m = l + (r - l) / 2; // getting the middle of whole array and treating it like its flat
            int row = m / cols; // getting spot in row
            int col = m % cols; // getting spot in columm
            if(target < matrix[row][col]){
                r = m - 1;
            } else if (target > matrix[row][col]){
                l = m + 1;
            } else {
                return true;
            }
        }
        return false;
    }
}
