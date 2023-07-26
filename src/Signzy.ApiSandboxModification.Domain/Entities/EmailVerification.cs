using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signzy.ApiSandboxModification.Domain.Entities
{
    public class Obj2
    {
        public Essentials essentials { get; set; }
        public EmailVerificationResult result { get; set; }
        public string id { get; set; }
        public string patronId { get; set; }
    }
    public class Essentials
    {
        public string emailId { get; set; }
    }
    public class EmailVerificationResult
    {
        public  EmailVerification? emailVerification { get; set; }
        public PersonalInfo personalInfo { get; set; }
        public DomainDetails domainDetails { get; set; }
        public DomainResult domainResult { get; set; }
        public string emailId { get; set; }
        public string domain { get; set; }
    }
    public class EmailVerification
    {
        public string validEmail { get; set; }
        public EmailValidationDetails emailValidationDetails { get; set; }

    }
    public class EmailValidationDetails
    {
        public string result { get; set; }
        public string score { get; set; }
        public string email { get; set; }
        public string regexp { get; set; }
        public string gibberish { get; set; }
        public string disposable { get; set; }
        public string webmail { get; set; }
        public string mx_records { get; set; }
        public string smtp_server { get; set; }
        public string smtp_check { get; set; }
        public string accept_all { get; set; }
        public string block { get; set; }
    }
    public class PersonalInfo
    {
        public Person person { get; set; }
        public Company company { get; set; }
    }
    public class DomainDetails
    {
        public string domain { get; set; }
        public string status { get; set; }
        public string updatedAt { get; set; }
        public string createdAt { get; set; }
        public string available { get; set; }
        public string registered { get; set; }
        public string domainId { get; set; }
        public string createdOn { get; set; }
        public string updatedOn { get; set; }
        public string expiresOn { get; set; }
        public Registrar registrar { get; set; }
        public AdminContacts[] adminContacts { get; set; }
        public TechnicalContacts[] technicalContacts { get; set; }
        public Nameservers[] nameservers { get; set; }
        public RegistrantContacts[] registrantContacts { get; set; }

    }
    public class DomainResult
    {
        public string ip { get; set; }
        public string continent_code { get; set; }
        public Continent continent { get; set; }
        public string country_code { get; set; }
        public Country country { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string timeZone { get; set; }

    }
    public class Registrar
    {
        public string id { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public string url { get; set; }
    }
    public class AdminContacts
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string createdOn { get; set; }
        public string updatedOn { get; set; }

    }
    public class TechnicalContacts
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string createdOn { get; set; }
        public string updatedOn { get; set; }
    }
    public class Nameservers
    {
        public string name { get; set; }
        public string ipv4 { get; set; }
        public string ipv6 { get; set; }
    }
    public class RegistrantContacts
    {
        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string organization { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string phone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string url { get; set; }
        public string createdOn { get; set; }
        public string updatedOn { get; set; }

    }
    public class Name
    {
        public string fullName { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
    }
    public class Continent
    {
        public string de { get; set; }
        public string en { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        [JsonProperty("pt-BR")]
        public string ptBR { get; set; }
        public string ru { get; set; }

        [JsonProperty("zh-CN")]
        public string zhCN { get; set; }
    }
    public class Country
    {
        public string de { get; set; }
        public string en { get; set; }
        public string es { get; set; }
        public string fr { get; set; }
        public string ja { get; set; }
        [JsonProperty("pt-BR")]
        public string ptBR { get; set; }
        public string ru { get; set; }
        [JsonProperty("zh-CN")]
        public string zhCN { get; set; }

    }

    public class Person
    {
        public Name name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string location { get; set; }
        public string timeZone { get; set; }
        public string utcOffset { get; set; }
        public Geo geo { get; set; }
        public string bio { get; set; }
        public string site { get; set; }
        public string avatar { get; set; }
        public Employment employment { get; set; }
        public Facebook facebook { get; set; }
        public Github github { get; set; }
        public Twitter twitter { get; set; }
        public Linkedin linkedin { get; set; }
        public Googleplus googleplus { get; set; }
        public Aboutme aboutme { get; set; }
        public Gravatar gravatar { get; set; }
        public string fuzzy { get; set; }
        public string emailProvider { get; set; }
        public string indexedAt { get; set; }

    }
    public class Geo
    {
        public string city { get; set; }
        public string state { get; set; }
        public string stateCode { get; set; }
        public string country { get; set; }
        public string countryCode { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public string streetNumber { get; set; }
        public string streetName { get; set; }
        public string subPremise { get; set; }
        public string postalCode { get; set; }

    }
    public class Employment
    {
        public string domain { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string role { get; set; }
        public string seniority { get; set; }

    }
    public class Facebook
    {
        public string handle { get; set; }
        public string likes { get; set; }
    }
    public class Github
    {
        public string handle { get; set; }
        public string id { get; set; }
        public string avatar { get; set; }
        public string company { get; set; }
        public string blog { get; set; }
        public string followers { get; set; }
        public string following { get; set; }
    }
    public class Twitter
    {
        public string handle { get; set; }
        public string id { get; set; }
        public string bio { get; set; }
        public string followers { get; set; }
        public string following { get; set; }
        public string statuses { get; set; }
        public string favorites { get; set; }
        public string location { get; set; }
        public string site { get; set; }
        public string avatar { get; set; }


    }
    public class Linkedin
    {
            public string handle { get; set; }

    }
    public class Googleplus
    {
        public string handle { get; set; }
    }
    public class Aboutme
    {
        public string handle { get; set; }
        public string bio { get; set; }
        public string avatar { get; set; }
    }
    public class Gravatar
    {
        public string handle { get; set; }
        public string urls { get; set; }
        public string avatar { get; set; }
        public List<object> avatars { get; set; }


    }
    public class Company
    {
        public string name { get; set; }
        public string legalName { get; set; }
        public string domain { get; set; }
        public List<object> domainAliases { get; set; }
        public Site site { get; set; }
        public Category category { get; set; }
        public List<string> tags { get; set; }
        public string description { get; set; }
        public string foundedYear { get; set; }
        public string location { get; set; }
        public string timeZone { get; set; }
        public string utcOffset { get; set; }
        public Geo geo { get; set; }
        public string logo { get; set; }
        public Facebook facebook { get; set; }
        public Linkedin linkedin { get; set; }
        public Twitter twitter { get; set; }
        public Crunchbase crunchbase { get; set; }
        public string emailProvider { get; set; }
        public string type { get; set; }
        public string ticker { get; set; }
        public Identifiers identifiers { get; set; }
        public string phone { get; set; }
        public Metrics metrics { get; set; }
        public string indexedAt { get; set; }
        public List<string> tech { get; set; }
        public Parent parent { get; set; }
        public UltimateParent ultimate_parent { get; set; }
    }
    public class Site
    {
        public List<object> phoneNumbers { get; set; }
        public List<string> emailAddresses { get; set; }
    }
    public class Category
    {
        public string sector { get; set; }
        public string industryGroup { get; set; }
        public string industry { get; set; }
        public string subIndustry { get; set; }
        public string sicCode { get; set; }
        public string naicsCode { get; set; }

    }
    public class Crunchbase
    {
        public string handle { get; set; }
    }
    public class Identifiers
    {
        public string usEIN { get; set; }
    }
    public class Metrics
    {
        public string alexaUsRank { get; set; }
        public string alexaGlobalRank { get; set; }
        public string employees { get; set; }
        public string employeesRange { get; set; }
        public string marketCap { get; set; }
        public string raised { get; set; }
        public string annualRevenue { get; set; }
        public string estimatedAnnualRevenue { get; set; }
        public string fiscalYearEnd { get; set; }

    }
    public class UltimateParent
    {
        public string domain { get; set; }
    }
    public class Parent
    {
        public string domain { get; set; }
    }
    
 
 
   






}
