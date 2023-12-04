using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public Joystick joystick; // Joystick beti�inin referans�

    void Update()
    {
        // Joystick'ten al�nan girdiye g�re nesneyi hareket ettir
        float moveHorizontal = joystick.Horizontal();
        float moveVertical = joystick.Vertical();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * Time.deltaTime);
    }
}
