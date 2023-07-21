using Nippon.PaintPartner.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Infrastructure.Mapping
{
    public static class Mapping
    {
        public const string Password = "Password";
        public const string UserName = "UserName";
        public const string FirstName = "FirstName";
        public const string LastName = "LastName";
        public const string Email = "Email";
        public const string Mac = "Mac";
        public const string Company = "Company";
        public const string InternalExternal = "InternalExternal";
        public const string UserType = "UserType";
        public const string UserTypeCode = "UserTypeCode";
        public const string From = "From";
        public const string To = "To";
        public const string IPAddress = "IPAddress";
        public const string CreatedBy = "CreatedBy";
        public const string CreatedDate = "CreatedDate";
        public const string ModifiedOn = "ModifiedOn";
        public const string ModifiedBy = "ModifiedBy";

        public const string Category = "CategoryID";
        public const string BaseProduct = "BaseProductID";
        public const string QType = "QType";
        public const string CategoryName = "CategoryName";
        public const string IsBaseProduct = "IsBaseProduct";
        public const string PaintSystemId = "PaintSystemId";
        public const string Product = "ProductId";
        public const string ProductCode = "ProductCode";
        public const string Description = "Description";
        public const string PackSizeLTR = "PackSizeVolumeInLitre";
        public const string SpecificGravity = "SpecificGravity";
        public const string ComponentType = "ComponentType";
        public const string RatioComponent = "RatioComponent";
        public const string AncillaryMixId = "AncillaryMixID";
        public const string RFU = "RFU";
        public const string BaseValA = "baseValueA";
        public const string BaseValB = "baseValueB";
        public const string BaseValC = "baseValueC";
        public const string BaseValD = "baseValueD";
        public const string SpecificGravityA = "SpecialGraivityA";
        public const string SpecificGravityB = "SpecialGraivityB";
        public const string SpecificGravityC = "SpecialGraivityC";
        public const string SpecificGravityD = "SpecialGraivityD";
        public const string BaseValueDdeduct = "baseValueDdeduct";

        public const string Language = "Language";
        public const string LanguageHeader = "LanguageHeader";
        public const string Status = "Status";
        public const string Screen = "Screen";
        public const string Platform = "Platform";
        public const string Label = "Label";
        public const string Code = "Code";
        public const string Translation = "Translation";
        public const string CatID = "CatID";

        public const string PanelItemsID = "PanelItemsID";
        public const string ColorStreamID = "ColorStreamID";
        public const string CoatType = "CoatType";
        public const string Quantity = "Qty";
        public const string Unit = "Unit";

        public const string ModuleName = "ModuleName";
        public const string DashBoardModuleName = "DashBoardModuleName";
        public const string PageName = "PageName";
        public const string AcivityName = "AcivityName";
        public const string UserId = "UserId";
        public const string IsActive = "IsActive";

        public const string FormulaId = "FormulaID";
        public const string Formula = "FormulaName";
        public const string ProductTypeId = "ProductTypeID";
        public const string ProductType = "ProductTypeName";
        public const string AdditiveId = "AdditiveTypeID";
        public const string AdditiveTypeName = "AdditiveTypeName";
        public const string Notes = "Notes";

        public const string SKUCode = "SKUCode";
        public const string ColourType = "ColourType";
        public const string Remarks = "Remarks";
        public const string SearchText = "SearchText";
        public const string Products = "Products";
        public const string AncillaryMixComponent = "AncillaryMixComponentTable";

        public const string AncillaryChartId = "AncillaryChartId";
        public const string Header1 = "Header1";
        public const string Header2 = "Header2";
        public const string Header3 = "Header3";
        public const string Header4 = "Header4";
        public const string Row1Col1 = "Row1Col1";
        public const string Row1Col2 = "Row1Col2";
        public const string Row1Col3 = "Row1Col3";
        public const string Row1Col4 = "Row1Col4";
        public const string Row2Col1 = "Row2Col1";
        public const string Row2Col2 = "Row2Col2";
        public const string Row2Col3 = "Row2Col3";
        public const string Row2Col4 = "Row2Col4";
        public const string Row3Col1 = "Row3Col1";
        public const string Row3Col2 = "Row3Col2";
        public const string Row3Col3 = "Row3Col3";
        public const string Row3Col4 = "Row3Col4";
        public const string PanelTempId = "PanelTempId";

        public const string PackSize = "PackSize";
        public const string Id = "Id";
        public const string Component = "Component";
        public const string Colour = "Colour";
        public const string Default = "Default";
        public const string Ratio = "Ratio";
        public const string ColorEffect = "ColourEffect";
        public const string HardenerId = "HardenerId";
        public const string ThinnerId = "ThinnerId";
        public const string AdditiveID = "AdditiveId";
        public const string ColourChartId = "ColourChartId";

        public const string AddressID = "AddressID";
        public const string AddressName = "AddressName";
        public const string Address1 = "Address1";
        public const string Address2 = "Address2";
        public const string Landmark = "Landmark";
        public const string Pincode = "Pincode";
        public const string City = "City";
        public const string State = "State";
        public const string Country = "Country";
        public const string ContactNo = "ContactNo";

        public const string ProdColoStreamID = "ProdColoStreamID";
        public const string ColorStream = "ProductColoStream";
        public const string ProdColoStreamName = "ProdColoStreamName";
        public const string ProdSequence = "ProdSequence";
        public const string IconText = "IconText";
        public const string IconColour = "IconColour";
        public const string IconTextColour = "IconTextColour";
        public const string ProdColoCode = "ProdColoCode";
        public const string ProdFlagName = "ProdFlagName";
        public const string ColoboStreamName = "ColoboStreamName";
        public const string ProductImageName = "ProductImageName";
        public const string ProductImagePath = "ProductImagePath";

        public const string CountryID = "CountryID";
        public const string CountryName = "CountryName";
        public const string CountryCode = "CountryCode";
        public const string DialingCode = "DialingCode";
        public const string CurrencyName = "CurrencyName";
        public const string CurrencyCode = "CurrencyCode";
        public const string LanguageName = "LanguageName";
        public const string LanguageCode = "LanguageCode";
        public const string CurrencySymbol = "CurrencySymbol";
        public const string CurrencyValue = "CurrencyValue";
        public const string CurrencyISOCode = "CurrencyISOCode";

        public const string Substrate = "Substrate";
        public const string WastageGram = "WastageGram";
        public const string WastagePercent = "WastagePercent";
        public const string ManufacturerId = "ManufacturerId";
        public const string Model = "Model";
        public const string Title = "Title";
        public const string ColorDirection = "ColorDirection";
        public const string ColorDirectionLevel = "ColorDirectionLevel";
        public const string Source = "Source";
        public const string Role = "Role";
        public const string UserID = "UserID";
        public const string SendID = "SendID";
        public const string AppTitle = "AppTitle";
        public const string Message = "Message";
        public const string FolderName = "FolderName";
        public const string ImageName = "ImageName";
        public const string ImageExt = "ImageExt";
        public const string SendStaus = "SendStaus";
        public const string OEMManufactureName = "OEMManufactureName";
        public const string OEMManufactureCode = "OEMManufactureCode";
        public const string OEMManufactureDescription = "OEMManufactureDescription";
        public const string OEMManufactureID = "OEMManufactureID";

        public const string PanelSourceID = "PanelSourceID";
        public const string SourceName = "SourceName";
        public const string SourceDescription = "SourceDescription";
        public const string Device = "Device";
        public const string CreatedOn = "CreatedOn";
        public const string DeviceID = "DeviceID";



        public const string ColoComponentName = "ColoComponentName";
        //public const string ColorStream = "ColorStream";
        public const string ColoComponentDesc = "ColoComponentDesc";
        public const string ColoType = "ColoType";
        public const string WastagePerc = "WastagePerc";
        public const string WastageGRM = "WastageGRM";
        public const string Color = "Color";
        public const string ColorComponentID = "ColorComponentID";
        public const string ColoComponentType = "ColoComponentType";

        public const string RoleID = "RoleID";

        public const string FunctionalityType = "FunctionalityType";
        public const string FuncID = "FuncID";
        public const string ColorGroup = "ColorGroup";
        public const string Folder = "Folder";
        public const string Image = "Image";
        public const string SortOrder = "SortOrder";
        public const string OEM = "OEM";
        public const string OEMID = "OEMID";

        public const string OEManufacturerID = "OEManufacturerID";
        public const string OEMModelID = "OEMModelID";
        public const string ColorGroupID = "ColorGroupID";
        public const string ColorCode = "ColorCode";
        public const string ColorName = "ColorName";
        public const string UniqueNo = "UniqueNo";
        public const string ColorType = "ColorType";
        public const string InternalCode = "InternalCode";
        public const string ColorStreamiID = "ColorStreamiID";
        public const string OEMYear = "OEMYear";
        public const string Combi = "Combi";
        public const string CombiCode = "CombiCode";
        public const string PatternNo = "PatternNo";


        public const string StreamID = "StreamID";
        public const string FromDate = "FromDate";
        public const string Todate = "Todate";
        public const string SearchFrom = "SearchFrom";
        public const string SourceFor = "SourceFor";
        public const string SourceFrom = "SourceFrom";
        public const string ToDate = "ToDate";

        public const string CCRID = "CCRID";
        public const string ColorItemsID = "ColorItemsID";
        public const string Qty = "Qty";
        public const string ContrySpecific = "ContrySpecific";
        public const string Pass = "Pass";
        public const string loginuserID = "loginuserID";

  
   

    }
}
