using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAviao : MonoBehaviour
{
    public GameObject aviao;
    public float velocidade = 0.05f;
    public int moedasColetadas = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // //código para mudar de direção
       
        // if(gameObject.transform.position.y>3){
        //   velocidade*= -1;
        // }else if(gameObject.transform.position.y< -3)
        // {
        //     velocidade*= -1;
        // }
        // transform.Translate(new Vector2(0,velocidade*Time.deltaTime));

        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(new Vector3(0,0.02f,0));
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(new Vector3(0,-0.02f,0));
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(new Vector3(-0.02f,0,0));
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(new Vector3(0.02f,0,0));
        }
        print("foram coletadas"+moedasColetadas);

    }
    void OnTriggerEnter2D(Collider2D body)
    {
        print("tocou");

        if(body.gameObject.CompareTag("moeda")){
            Destroy(body.gameObject);
            moedasColetadas++;
        }

    }
}

