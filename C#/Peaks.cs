using System;
using System.Collections.Generic;

class Peaks {
    static void Main() {
        int[] arr = {1, 2, 2, 2, 3, 8, 5, 3, 2, 1, 5};
        Dictionary<string, List<int>> myDict = new Dictionary<string, List<int>>();
        
        for(int i = 1; i < arr.Length - 1; i++) {

            if(arr[i] > arr[i-1] && arr[i] > arr[i+1]){
                List<int> ith_value = new List<int>{arr[i]};
                myDict.Add(i.ToString(), ith_value);
            }
            
            if(arr[i] == arr[i+1]){
                int plateau = arr[i];
                int start = i;
                int count = 0;
                while(i < arr.Length && arr[i] == plateau) {
                    count++;
                    i++;
                }
                if(i < arr.Length && arr[i] != plateau) {
                    List<int> i_value = new List<int>{plateau};
                    myDict.Add(start.ToString(), i_value);
                }
                i--;
            }
        }
        
        foreach(var idk in myDict) {
            Console.WriteLine($"pos: {idk.Key}, peaks: {string.Join(",", idk.Value)}");
        }
    }
}
