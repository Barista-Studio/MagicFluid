using Obi;
using UnityEngine;
namespace Labs.Lab1_Query
{
    public class ShowDistance : MonoBehaviour
    {
        public ObiSolver solver;
        public float radius = 1;

        public ObiEmitter e1;

        void Update()
        {
            int filter = ObiUtils.MakeFilter(ObiUtils.CollideWithEverything, 0);

            var query = new QueryShape(QueryShape.QueryType.Sphere, Vector3.zero, Vector3.zero, 0, radius, filter);
            var xform = new AffineTransform(transform.position, transform.rotation, transform.localScale);

            QueryResult[] results = solver.SpatialQuery(query, xform);

            // Iterate over results and draw their distance to the point.
            // We're assuming the solver only contains 0-simplices (particles).
            for (int i = 0; i < results.Length; ++i)
            {
                if (results[i].distance < radius)
                {
                    Vector3 pos = solver.transform.TransformPoint(solver.positions[results[i].simplexIndex]);
                    Debug.DrawLine(transform.position, pos, Color.yellow);
                }
            }
        }
    }
}
