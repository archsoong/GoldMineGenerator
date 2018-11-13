using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldMineGenerator : MonoBehaviour 
{
    public GameObject goldMinePrefab;

	// Use this for initialization
	void Start () 
	{
		Q3();
	}

	public void Q1()
	{
		for(int i = 0; i < 7; i++)
        {
        	float x1 = -10.5f + 3.5f * i;
        	float y1 = -10.5f + 3.5f * i;
        	float y2 = 10.5f - 3.5f * i;

            Instantiate(goldMinePrefab, new Vector3(x1, y1, 0), Quaternion.identity);
            Instantiate(goldMinePrefab, new Vector3(x1, y2, 0), Quaternion.identity);
        }
	}

	public void Q2()
	{
		for(int i = 0; i < 9; i++)
        {
        	float x = -7 + (7 * (i%3));      // 取餘數，每三次就會回歸左邊原位     
        	float y = 7 + (-7 * ((int)i/3)); // 把浮點數轉換回整數，去掉分數

            Instantiate(goldMinePrefab, new Vector3(x, y, 0), Quaternion.identity);
        }
	}

	public void Q3()
	{
		int i = 0;
		while(i < 9)
        {
        	float x = -7 + (7 * (i%3));      // 取餘數，每三次就會回歸左邊原位     
        	float y = 7 + (-7 * ((int)i/3)); // 把浮點數轉換回整數，去掉分數

            Instantiate(goldMinePrefab, new Vector3(x, y, 0), Quaternion.identity);
            i++;
        }
	}
}
