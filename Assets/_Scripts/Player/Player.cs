using UnityEngine;

public class Player : MonoBehaviour
{
    private float       _HP = 100;

    #region ÑÂÎÉÑÒÂÀ
    public float HP
    {
        get
        {
            return (_HP);
        }
        set
        {
            _HP = value;
        }
    }
    #endregion
}
