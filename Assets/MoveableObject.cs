using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public Joystick joystick; // Joystick betiðinin referansý

    void Update()
    {
        // Joystick'ten alýnan girdiye göre nesneyi hareket ettir
        float moveHorizontal = joystick.Horizontal();
        float moveVertical = joystick.Vertical();

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.Translate(movement * Time.deltaTime);
    }
}
