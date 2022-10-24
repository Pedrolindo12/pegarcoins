using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CriaMoeda : MonoBehaviour
{
    public GameObject moeda;
    
    // Start is called before the first frame update
    void Start()
    {
        
        CriaParabola();
     
    }
    void CriaReta(){
        float y;
        for (float x = -9; x < -5; x+=1.9f)
        {            
                // reta
                y = 0.0f*x+0;
                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
        }


    }
    void CriaRetaVertical(){
        float y;
        for (float x = 0; x < 5; x+=1.9f)
        {            
                // reta
                y = 0.0f*x+-4;
                Instantiate(moeda, new Vector3(y,x,-2), Quaternion.identity);
        }
    }
    void CriaReta(float b, float minX, float maxX){
            float y;
            for (float x = minX; x < maxX; x+=1.9f)
            {            
                    // reta
                    y = 0.0f*x+b;
                    Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
            }
        }

    void CriaParabola(){
        float y;

        for (float x = -2; x < 7.5f; x+=0.9f)
        {
            
                // parábola
                y = (float)(-0.4*x*x+2*x+0);
            
                Instantiate(moeda, new Vector3(y,x,-2), Quaternion.identity);
                
            
        }
    }
    void CriaCircunferencia(){
        float y,x;
        float raio = 2.5f;

        for (double teta = 0; teta <  Math.PI; teta+=0.3)
        {
            
                //circunferência
                x = (float)(raio*Math.Cos(teta));
                y = (float)(raio*Math.Sin(teta));

                Instantiate(moeda, new Vector3(x,y,-2), Quaternion.identity);
                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
