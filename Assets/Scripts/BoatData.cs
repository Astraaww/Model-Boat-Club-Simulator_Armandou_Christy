using UnityEngine;

[CreateAssetMenu(fileName = "BoatData", menuName = "Scriptable Objects/BoatData")]
public class BoatData : ScriptableObject
{

    [SerializeField]
    private float width = 16f;

    [SerializeField]
    private float length = 9f;

    [Range(0, 300)]
    [SerializeField]
    private int SpawningCount;

    [Range(0, 10)]
    [SerializeField]
    private float maxSpeed = 6f;

    [Range(0.1f, 45f)]
    [SerializeField]
    private float steeringSpeed = 4.5f;

    [Range(.01f, .5f)]
    [SerializeField]
    private float maxForce = .03f;

    [Range(1, 10)]
    [SerializeField]
    private float neighborhoodRadius = 4f;

    [Range(0.1f, 10f)]
    [SerializeField]
    private float separationRadius = 2.4f;

    [Range(0, 3)]
    [SerializeField]
    private float separationAmount = 1.1f;

    [Range(0, 3)]
    [SerializeField]
    private float cohesionAmount = 0.3f;

    [Range(0, 3)]
    [SerializeField]
    private float alignmentAmount = 0.5f;

    public float Width
    {         get { return width; } }

    public float Length
    {         get { return length; } }

    public int SpawningCountValue
    {         get { return SpawningCount; } }

    public float MaxSpeed
    {         get { return maxSpeed; } }

    public float SteeringSpeed
    {         get { return steeringSpeed; } }

    public float MaxForce
    {         get { return maxForce; } }

    public float NeighborhoodRadius
    {         get { return neighborhoodRadius; } }

    public float SeparationRadius
    {         get { return separationRadius; } }

    public float SeparationAmount
    {         get { return separationAmount; } }

    public float CohesionAmount
    {         get { return cohesionAmount; } }

    public float AlignmentAmount
    {         get { return alignmentAmount; } }
}
