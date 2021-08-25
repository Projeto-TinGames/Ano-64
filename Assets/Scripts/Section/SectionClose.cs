using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionClose : MonoBehaviour {
    public void Close() {
        SectionManager.instance.EnterSection(false,false,null);
    }
}
