using Obi;
using UnityEngine;
public class ContactVolumeBox : MonoBehaviour
{
    Bounds m_aabbBox;
    ObiSolver solver;
    public float volume_size = 0.01f;


    void Start()
    {
        var collider_mesh = GetComponent<MeshCollider>().sharedMesh;
        m_aabbBox = collider_mesh.bounds;
        solver = FindObjectOfType<ObiSolver>();
    }

    // Update is called once per frame
    void Update() { }
}
