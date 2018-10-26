namespace ExerciseTracker.Model.Interface
{
    public interface IDomainObject<TKey>
    {
        TKey Id { get; set; }
    }
}
