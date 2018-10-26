namespace ExerciseTracker.Model.Interface
{
    public interface IModelObject<TKey>
    {
        TKey Id { get; set; }
    }
}
