using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    public PuzzlePiece[] pieces;

    public bool IsPuzzleSolved
    {
        get
        {
            foreach (var piece in pieces)
            {
                if (!piece.IsInCorrectPosition)
                    return false;
            }
            return true;
        }
    }
}
