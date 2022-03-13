﻿using Newtonsoft.Json;

namespace Cats.ApiClient.Model.Breed
{
    public class Breed
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("wikipedia_url")]
        public string WikipediaUrl { get; set; }

        [JsonProperty("adaptability")]
        public int Adaptability { get; set; }

        [JsonProperty("affection_level")]
        public int AffectionLevel { get; set; }

        [JsonProperty("alt_names")]
        public string AltNames { get; set; }

        [JsonProperty("child_friendly")]
        public int ChildFriendly { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country_codes")]
        public string CountryCodes { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dog_friendly")]
        public int DogFriendly { get; set; }

        [JsonProperty("energy_level")]
        public int EnergyLevel { get; set; }

        [JsonProperty("experimental")]
        public int Experimental { get; set; }

        [JsonProperty("grooming")]
        public int Grooming { get; set; }

        [JsonProperty("hairless")]
        public int Hairless { get; set; }

        [JsonProperty("health_issues")]
        public int HealthIssues { get; set; }

        [JsonProperty("hypoallergenic")]
        public int Hypoallergenic { get; set; }

        [JsonProperty("indoor")]
        public int Indoor { get; set; }

        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        [JsonProperty("life_span")]
        public string LifeSpan { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("natural")]
        public int Natural { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("rare")]
        public int Rare { get; set; }

        [JsonProperty("reference_image_id")]
        public string ReferenceImageId { get; set; }

        [JsonProperty("rex")]
        public int Rex { get; set; }

        [JsonProperty("shedding_level")]
        public int SheddingLevel { get; set; }

        [JsonProperty("short_legs")]
        public int ShortLegs { get; set; }

        [JsonProperty("social_needs")]
        public int SocialNeeds { get; set; }

        [JsonProperty("stranger_friendly")]
        public int StrangerFriendly { get; set; }

        [JsonProperty("suppressed_tail")]
        public int SuppressedTail { get; set; }

        [JsonProperty("temperament")]
        public string Temperament { get; set; }

        [JsonProperty("vetstreet_url")]
        public string VetstreetUrl { get; set; }

        [JsonProperty("vocalisation")]
        public int Vocalisation { get; set; }

        [JsonProperty("weight")]
        public Weight Weight { get; set; }
    }
}
