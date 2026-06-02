using UnityEngine;

public class NotesManager : MonoBehaviour
{
    Collider notesCollider;
    static public bool isTouch = false;
    Vector3 setPos = new Vector3(13,1,1);
    void Start()
    {
        notesCollider = GetComponent<Collider>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTouch = true;
        }
        else
        {
            isTouch = false;
        }
    }
}
