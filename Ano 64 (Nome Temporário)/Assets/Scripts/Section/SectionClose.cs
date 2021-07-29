using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionClose : MonoBehaviour {
    public void Close() {
        SectionManager.instance.SetSection(false,false,null);
    }
}
