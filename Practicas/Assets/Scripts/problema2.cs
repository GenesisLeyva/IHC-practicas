using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class problema2 : MonoBehaviour
{
    public int[] nums = new int[4] {11,7,2,15};
    public int target = 26;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Problema 2:");
        int[] result = sumaDos(nums, target);
        Debug.Log(string.Join(", ", result));
        
    }
    public int[] sumaDos(int[] nums, int target)
    {
        int[] result = new int[2];
        int i = 0,j = 1,bandera = 0;

        do{
            if(nums[i] + nums[j] == target) bandera = 1;
            else{
                if(j == (nums.Length- 1)) j=0;
                else j++;
                if(i == (nums.Length -1)) bandera=-1;
                else i++;
            }	
        }while(bandera == 0);

        result[0] = i;
        result[1] = j;

        return result;
    }

    
}
