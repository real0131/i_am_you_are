using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MoveDpad : MonoBehaviour {
    public float speed = 1.5f;
    public void getBtn(Button btn)
    {
        if (btn.GetInstanceID() == -355522 )
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime); //left
        }
        if (btn.GetInstanceID() == -357702)
        {
            transform.Translate(-1 * Vector2.up * speed * Time.deltaTime); //down
        }
        if (btn.GetInstanceID() == -357496)
        {
            transform.Translate(-1 * Vector2.left * speed * Time.deltaTime); //right
        }
        if (btn.GetInstanceID() == -357292)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime); //up
        }
    }
	public void dpad_up(Button btn)
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); //up
    }
    public void dpad_down(Button btn)
    {
        transform.Translate(-1 * Vector2.up * speed * Time.deltaTime); //down
    }
    public void dpad_left(Button btn)
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); //left
    }
    public void dpad_right(Button btn)
    {
        transform.Translate(-1 * Vector2.left * speed * Time.deltaTime); //right
    }
}
