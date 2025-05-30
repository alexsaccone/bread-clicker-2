using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;


public class clickBread : MonoBehaviour
{
    [SerializeField] private TMP_Text bread_text_field;
    [SerializeField] private TMP_Text bps_text_field;

    int bread;
    int bread_per_click;
    int bread_per_second;

    void Start()
    {
        bread = 0;
        bread_per_click = 1;
        bread_per_second = 0;
        bread_text_field.text = "Bread:\n" + bread;
        bps_text_field.text = "BPS:\n" + bread_per_second;
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                bread += bread_per_click;

                bread_text_field.text = "Bread:\n" + bread;
            }
        }
    }
}