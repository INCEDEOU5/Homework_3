using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    /* Create a List of numbers that are odd and are divisible by the number 7 between 1 and 144.
     * You should have a list that looks like this 7, 21, 35, 49, 63, 77, 91, 105, 119, 133
     * Declare an array that's half the size of the list and save every other number from the list into the array 
     * You should have a array that looks like this 7, 35, 63, 91, 119
    */
    void Start()
    {
        int[] numbers = new int[10] { 7, 21, 35, 49, 63, 77, 91, 105, 119, 133 };
        int[] new_numbers = new int[5];
        int[] new_new_numbers = new int[5] { 7, 35, 63, 91, 119 };
    }
}
