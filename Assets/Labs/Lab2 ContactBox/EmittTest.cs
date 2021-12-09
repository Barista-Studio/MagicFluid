using Obi;
using UnityEngine;
public class EmittTest : MonoBehaviour
{
    ObiEmitter emitter;
    // Start is called before the first frame update
    void Start()
    {
        emitter = GetComponent<ObiEmitter>();

    }

    // Update is called once per frame
    void Update()
    {
        emitter.EmitParticle( 0, Time.deltaTime );
    }
}
