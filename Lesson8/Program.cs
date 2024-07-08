using CountryData.Standard;

public static class Program {
    
      private static readonly CountryHelper _countryHelper = new CountryHelper();
      
        public static void Main(){
            // GetCountries();

            GetCountryData();
          
        }
         
        //  // Get all countries
        //  static void GetCountries() {
        //     var countries = _countryHelper.GetCountries();
        //     foreach (var country in countries)
        //     {
        //         Console.WriteLine(country);
        //     }
        //  }


           static void  GetCountryData () {
            var countries = _countryHelper.GetCountryData();
            foreach (var country in countries)
            {
                Console.WriteLine(country.CountryShortCode);
                Console.WriteLine(country.CountryName);
                Console.WriteLine(country.PhoneCode);
            }
         }




    }