using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISaver
{
    void SaveScore(int score, string path = null);
}
