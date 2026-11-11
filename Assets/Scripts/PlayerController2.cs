using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public int speed = 20;
    void Start()
    {
       
    }

   
    void Update()
    {//Движение вперед.
        //
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate( Vector3.forward * Time.deltaTime * speed);
        }
        //Движение назад
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        //Движение вправо
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        //Движение влево
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
