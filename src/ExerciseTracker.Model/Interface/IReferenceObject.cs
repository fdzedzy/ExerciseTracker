namespace ExerciseTracker.Model.Interface
{
    public interface IReferenceObject<TKey>
    {
        TKey Id { get; set; }
        string Name { get; set; }
    }
}
