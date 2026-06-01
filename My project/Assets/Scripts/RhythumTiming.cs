using UnityEngine;

public class RhythumTiming : MonoBehaviour
{

    [SerializeField] private Transform playerPos;
    [SerializeField] private Transform notesPos;

    [HideInInspector] public float judge;

    private bool perfect = false;
    private bool nomal = false;
    private bool bad = false;

    private void Update()
    {
        // Player位置とノーツの位置計算
        judge = Mathf.Abs(playerPos.position.y - notesPos.position.y);

        if(judge <= 0)
        {
            perfect = true;
        }
        else if(judge <= 1)
        {
            nomal = true;
        }
        else if(judge <= 3)
        {
            bad = true;
        }
        else
        {
            perfect = false;
            nomal = false;
            bad = false;
        }
    }

    public void IsClickManager()
    {
        if (perfect)
        {

        }
        if (nomal)
        {

        }
        if (bad)
        {

        }
    }
}
