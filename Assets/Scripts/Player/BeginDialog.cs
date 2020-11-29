using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginDialog : MonoBehaviour
{
    public Fungus.Flowchart dialog;
    private bool dialogExhausted, inRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.E) && !dialogExhausted)
            StartDialog();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("In range with " + collision.name);
        if (collision.GetComponent<PlayerMovement>().CurrentCharacter())
            inRange = true;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inRange = false;
    }

    private void StartDialog()
    {
        dialog.gameObject.SetActive(true);
        Debug.Log("Starting dialog");
        dialogExhausted = true;
    }

    public void ResetDialog()
    {
        dialogExhausted = false;
    }
}
