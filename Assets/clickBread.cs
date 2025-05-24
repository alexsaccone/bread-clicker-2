using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class clickBread : MonoBehaviour
{
    [SerializeField] private TMP_Text breadTextField;
    int bread;
    int bread_click;

    void Start()
    {
        bread = 0;
        bread_click = 1;
        breadTextField.text = "Bread:\n" + bread;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                bread += bread_click;

                breadTextField.text = "Bread:\n" + bread;
            }
        }
    }
}