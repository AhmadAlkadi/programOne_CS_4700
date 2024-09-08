/***************************************************************
*file: MonoDevelop.cs
*author: Ahmad Alkadi
*class: CS 4700 – Game Development
*assignment: program 1
*date last modified: 9/7/2024
*
*purpose: This programs goal is to print a 2D array in normal order, reverse order, 
*and print out the minimum and maximum values in the array.
*
****************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoDevelop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // rows and columns the purpose of this is to know the size of the 2D array
        // using Random.Range makes it possible to use any number from 1 to 20 and its always randomized
        int rows = Random.Range(1, 20);
        int columns = Random.Range(1, 20);
        int[,] arrayOne;
        arrayOne = new int[rows, columns];

        // purpose of this loop is to fill up the array with random numbers from 0 to 100 
        for(int i = 0; i< rows; i++)
        {
            for(int j = 0; j< columns; j++)
            {
                arrayOne[i,j] = Random.Range(0, 100);
            }
        }

        // purpose of this loop is to print the normal order of the 2D array
        // also the purpose of this string is just to make it look nicer
        string normalOrder = null;
        print("Normal order:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (j != 0)
                {
                    normalOrder = normalOrder + "," + arrayOne[i, j].ToString();
                }
                else
                {
                    normalOrder =  arrayOne[i, j].ToString();
                }
            }
            print(normalOrder);
            normalOrder = null;
        }

        // purpose of this loop is to print the reverse order of the 2D array
        // also the purpose of this string is just to make it look nicer
        string reverseOrder = null;
        print("Reverse order:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = columns-1; j > -1; j--)
            {
                if(j == columns - 1)
                {
                    reverseOrder = arrayOne[i, j].ToString();
                }
                else
                {
                    reverseOrder = reverseOrder + "," +arrayOne[i, j].ToString();
                }
            }
            print(reverseOrder);
            reverseOrder = null;
        }

        // purpose of this loop is to print out the minimum and maximum values in the array.
        int min = -1;
        int max = -1;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (min == -1 && max == -1)
                {
                    min = arrayOne[i, j];
                    max = arrayOne[i, j];
                }
                else
                {
                    if(min > arrayOne[i, j])
                    {
                        min = arrayOne[i, j];
                    }

                    if(max < arrayOne[i, j])
                    {
                        max = arrayOne[i, j];
                    }
                }
            }
        }
        print("Maximum values in the array: " + max);
        print("Minimum values in the array: " + min);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
