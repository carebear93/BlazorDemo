using System;

public class MeteorLandingModel
{
    public string name { get; set; }
    public string id { get; set; }
    public string nametype { get; set; }
    public string recclass { get; set; }
    public string mass { get; set; }
    public string fall { get; set; }
    public DateTime year { get; set; }
    public string reclat { get; set; }
    public string reclong { get; set; }
    public Geolocation geolocation { get; set; }
    public string computed_region_cbhk_fwbd { get; set; }
    public string computed_region_nnqa_25f4 { get; set; }
}

public class Geolocation
{
    public string type { get; set; }
    public float[] coordinates { get; set; }
}
