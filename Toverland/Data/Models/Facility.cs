namespace Toverland.Data.Models;

public enum State
{
    Open,
    Closed,
    Maintenance
}

public enum FacilityType {
    RIDE,
    FOOD_DRINKS,
    RESTROOM,
    FIRST_AID,
    INFORMATION,
    SHOW,
    SHOP
}

public class Facility
{
    public int Id { get; private set; }

    public string Title { get; private set; }

    public int? WaitTime { get; private set; }

    public string SubTitle { get; private set; }
    
    public string Description { get; private set; }
    
    public string ImageUrl { get; private set; }

    public string MapUrl { get; private set; }
    
    public State State { get; private set; }
    
    public FacilityType Type { get; private set; }


    public Facility(string title, int id, string subTitle, string description, string imageUrl, State state)
    {
        this.Title = title;
        this.Id = id;
        this.SubTitle = subTitle;
        this.Description = description;
        this.ImageUrl = imageUrl;
        this.State = state;
    }
    
    
    public void SetWaitTime(int waitTime)
    {
        this.WaitTime = waitTime;
    }
}