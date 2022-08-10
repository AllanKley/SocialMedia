namespace Model;


public class Tag : Interfaces.IDataManipulation
{
    private int Id { get; set; }
    private string Name { get; set; }


    private List<int> TagPostIds { get; set; }
    private List<TagPost> TagPosts { get; set; }



   

    public void delete()
    {
        throw new NotImplementedException();
    }

    public int save()
    {
        throw new NotImplementedException();
    }

    public void update()
    {
        throw new NotImplementedException();
    }
}
