using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

public class XmlSorter
{
    public static void Main()
    {
		// Load the XML data from a file or a string
		string xmlData = @"<root>
                <register type=""LexisNexis.Navigation.ExternalProduct"" mapTo=""LexisNexis.Navigation.ExternalProduct"" name=""CaseBaseLegalAnalytics"">
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518399"" />
				<property name = ""Key"" value = ""CaseBaseLegalAnalytics"" />
				<property name = ""Name"" value = ""CaseBase Legal Analytics"" />
				<property name = ""Priority"" value = ""1"" />
			</register >
			<!-- [2] Firm Manager -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""FirmManager"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1516772"" />
				<property name = ""Key"" value = ""FirmManager"" />
				<property name = ""Name"" value = ""Firm Manager"" />
				<property name = ""PathKey"" value = ""FirmManagerURL"" />
				<property name = ""Priority"" value = ""2"" />
			</register >
			<!-- [3] High Court Analyzer -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""HighCourtAnalyser"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518401"" />
				<property name = ""Key"" value = ""HighCourtAnalyser"" />
				<property name = ""Name"" value = ""High Court Analyser"" />
				<property name = ""PathKey"" value = ""CaseBaseLinkforHighCourtAnalyserURL"" />
				<property name = ""Priority"" value = ""3"" />
			</register >
			<!-- [4] Intelligize -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Intelligize"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518569"" />
				<property name = ""Key"" value = ""Intelligize"" />
				<property name = ""Name"" value = ""Intelligize"" />
				<property name = ""PathKey"" value = ""IntelligizeURL"" />
				<property name = ""Priority"" value = ""4"" />
			</register >
			<!-- [5] Law360 -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Law360"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1001021"" />
				<property name = ""Key"" value = ""Law360"" />
				<property name = ""Name"" value = ""Law360"" />
				<property name = ""PathKey"" value = ""Law360URL"" />
				<property name = ""Priority"" value = ""5"" />
			</register >
			<!-- [6] LexMachina -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""LexMachina"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1527701"" />
				<property name = ""Key"" value = ""LexMachina"" />
				<property name = ""Name"" value = ""Lex Machina"" />
				<property name = ""PathKey"" value = ""LexMachinaURL"" />
				<property name = ""Priority"" value = ""6"" />
			</register >
			<!-- [7] LexMachinaOld added temporarily - Please see comment in Navigation Module ProductSwitcherHelper.BuildProductModelsCollectionAsync method -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""LexMachinaOld"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518571"" />
				<property name = ""Key"" value = ""LexMachina"" />
				<property name = ""Name"" value = ""Lex Machina"" />
				<property name = ""PathKey"" value = ""LexMachinaURL"" />
				<property name = ""Priority"" value = ""7"" />
			</register >
			<!-- [7] Lexis.com -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""LawSchoolLexisDotcom"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1000586"" />
				<property name = ""Key"" value = ""LawSchoolLexisDotcom"" />
				<property name = ""Name"" value = ""Lexis.com"" />
				<property name = ""PathKey"" value = ""LawSchoolLexisDotcomURL"" />
				<property name = ""Priority"" value = ""7"" />
			</register >
			<!-- [8] Lexis Link for Bridged Users -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""LexisLinkforBridgedUsers"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1512325"" />
				<property name = ""Key"" value = ""LexisLinkforBridgedUsers"" />
				<property name = ""Name"" value = ""Lexis.com"" />
				<property name = ""PathKey"" value = ""LexisLinkforBridgedUsersURL"" />
				<property name = ""Priority"" value = ""8"" />
				<property name = ""NeedsToken"" value = ""true"" />
			</register >
			<!-- [9] Lexis Diligence -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Diligence"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518392"" />
				<property name = ""Key"" value = ""Diligence"" />
				<property name = ""Name"" value = ""Lexis Diligence®"" />
				<property name = ""PathKey"" value = ""DiligenceURL"" />
				<property name = ""Priority"" value = ""9"" />
			</register >
			<!-- [10] Dossier -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Dossier"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1001005"" />
				<property name = ""Key"" value = ""Dossier"" />
				<property name = ""Name"" value = ""LexisNexis® Dossier"" />
				<property name = ""PathKey"" value = ""DossierURL"" />
				<property name = ""Priority"" value = ""10"" />
			</register >
			<!-- [11] LexisNexis GetAndPrint -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""GetAndPrint"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1000579"" />
				<property name = ""Key"" value = ""GetAndPrint"" />
				<property name = ""Name"" value = ""LexisNexis® GetAndPrint"" />
				<property name = ""PathKey"" value = ""GetAndPrintURL"" />
				<property name = ""Priority"" value = ""11"" />
			</register >
			<!-- [12] LexisNexis for Law Schools -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""LawSchoolPortal"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1000214"" />
				<property name = ""Key"" value = ""LawSchoolPortal"" />
				<property name = ""Name"" value = ""LexisNexis® for Law Schools"" />
				<property name = ""PathKey"" value = ""LawSchoolPortalURL"" />
				<property name = ""Priority"" value = ""12"" />
			</register >
			<!-- [13] LexisNexis Newsdesk -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Newsdesk"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518394"" />
				<property name = ""Key"" value = ""Newsdesk"" />
				<property name = ""Name"" value = ""LexisNexis Newsdesk®"" />
				<property name = ""PathKey"" value = ""NewsdeskURL"" />
				<property name = ""Priority"" value = ""13"" />
			</register >
			<!-- [14] LexisNexis Publisher -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Publisher"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1001006"" />
				<property name = ""Key"" value = ""Publisher"" />
				<property name = ""Name"" value = ""LexisNexis® Publisher"" />
				<property name = ""PathKey"" value = ""PublisherURL"" />
				<property name = ""Priority"" value = ""14"" />
			</register >
			<!-- [15] Securities Mosaic -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""SecuritiesMosaic"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1000215"" />
				<property name = ""Key"" value = ""SecuritiesMosaic"" />
				<property name = ""Name"" value = ""Lexis® Securities Mosaic®"" />
				<property name = ""PathKey"" value = ""SecuritiesMosaicURL"" />
				<property name = ""Priority"" value = ""15"" />
			</register >
			<!-- [16] State Net -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""StateNet"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1000212"" />
				<property name = ""Key"" value = ""StateNet"" />
				<property name = ""Name"" value = ""LexisNexis® State Net®"" />
				<property name = ""PathKey"" value = ""StateNetURL"" />
				<property name = ""Priority"" value = ""16"" />
			</register >
			<!-- [17] mlex -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Mlex"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518396"" />
				<property name = ""Key"" value = ""Mlex"" />
				<property name = ""Name"" value = ""mlex marketing insight"" />
				<property name = ""PathKey"" value = ""MLexURL"" />
				<property name = ""Priority"" value = ""17"" />
			</register >
			<!-- [18] New South Wales Court of Appeal Analyser -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""NewSouthWalesCourtOfAppealAnalyser"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518565"" />
				<property name = ""Key"" value = ""NewSouthWalesCourtOfAppealAnalyser"" />
				<property name = ""Name"" value = ""New South Wales Court of Appeal Analyser"" />
				<property name = ""PathKey"" value = ""CaseBaseLinkforNewSouthWalesCourtOfAppealAnalyserURL"" />
				<property name = ""Priority"" value = ""18"" />
			</register >
			<!-- [19] LexisNexis Nexis -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Nexis"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518424"" />
				<property name = ""Key"" value = ""Nexis"" />
				<property name = ""Name"" value = ""Nexis®"" />
				<property name = ""PathKey"" value = ""NexisURL"" />
				<property name = ""Priority"" value = ""19"" />
			</register >
			<!-- [20] Capital Monitor -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""CapitalMonitor"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1522294"" />
				<property name = ""Key"" value = ""CapitalMonitor"" />
				<property name = ""Name"" value = ""LexisNexis®CapitalMonitor"" />
				<property name = ""PathKey"" value = ""CapitalMonitorURL"" />
				<property name = ""Priority"" value = ""20"" />
			</register >
			<!-- [21] LexisChina -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""LexisChina"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""9999998"" />
				<property name = ""Key"" value = ""LexisChinaLink"" />
				<property name = ""Name"" value = ""LexisNexis®LexisChina"" />
				<property name = ""PathKey"" value = ""LexisChinaRedirectionPage"" />
				<property name = ""Priority"" value = ""50"" />
			</register >
			<!-- [22] Federal Court Analyser -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""FederalCourtAnalyser"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518904"" />
				<property name = ""Key"" value = ""FederalCourtAnalyser"" />
				<property name = ""Name"" value = ""Federal Court Analyser"" />
				<property name = ""PathKey"" value = ""CaseBaseLinkforFederalCourtAnalyserURL"" />
				<property name = ""Priority"" value = ""21"" />
			</register >
			<!-- [23] New Zealand Appellate Analyser -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""NewZealandAppellateAnalyser"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1518905"" />
				<property name = ""Key"" value = ""NewZealandAppellateAnalyser"" />
				<property name = ""Name"" value = ""New Zealand Appellate Analyser"" />
				<property name = ""PathKey"" value = ""CaseBaseLinkforNewZealandAppellateAnalyserURL"" />
				<property name = ""Priority"" value = ""22"" />
			</register >
			<!-- [24] ACCC Analyser -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""ACCCAnalyser"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1524899"" />
				<property name = ""Key"" value = ""ACCCAnalyser"" />
				<property name = ""Name"" value = ""ACCC Analyser"" />
				<property name = ""PathKey"" value = ""CaseBaseLinkforACCCAnalyserURL"" />
				<property name = ""Priority"" value = ""23"" />
			</register >
			<!-- [25] Dossier New -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""DossierFC"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1523139"" />
				<property name = ""Key"" value = ""DossierFC"" />
				<property name = ""Name"" value = ""LexisNexis® Dossier"" />
				<property name = ""PathKey"" value = ""DossierFCURL"" />
				<property name = ""Priority"" value = ""10"" />
			</register >
			<!-- [26] PSL -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""ProfessionalSupportLawyer"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1527134"" />
				<property name = ""Key"" value = ""ProfessionalSupportLawyer"" />
				<property name = ""Name"" value = ""Lexis®PSL"" />
				<property name = ""PathKey"" value = ""ProfessionalSupportLawyerURL"" />
				<property name = ""Priority"" value = ""50"" />
			</register >
			<!-- [27] Lexis Diligence New -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""DiligenceNP"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1522855"" />
				<property name = ""Key"" value = ""DiligenceNP"" />
				<property name = ""Name"" value = ""Lexis Diligence®"" />
				<property name = ""PathKey"" value = ""DiligenceNPURL"" />
				<property name = ""Priority"" value = ""9"" />
			</register >
			<!-- [28] LexisNexis Newsdesk -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""NewsdeskNP"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1525776"" />
				<property name = ""Key"" value = ""NewsdeskNP"" />
				<property name = ""Name"" value = ""LexisNexis Newsdesk®"" />
				<property name = ""PathKey"" value = ""NewsdeskNPURL"" />
				<property name = ""Priority"" value = ""13"" />
			</register >
			<!-- [29] LexisLibrary -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""LexisLibrary"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""10000100"" />
				<property name = ""Key"" value = ""LexisLibraryURL"" />
				<property name = ""Name"" value = ""Lexis®Library"" />
				<property name = ""PathKey"" value = ""LexisLibraryURL"" />
				<property name = ""Priority"" value = ""70"" />
			</register >
			<!-- [30] LexisNexisBriefAnalyzer * *BriefAnalyzer is not an external product but it should behave same as external one * *-->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""BriefAnalyzer"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1525036"" />
				<property name = ""Key"" value = ""BriefAnalysis"" />
				<property name = ""Name"" value = ""LexisNexis BriefAnalyzer"" />
				<property name = ""PathKey"" value = ""briefanalyzerURL"" />
				<property name = ""Priority"" value = ""17"" />
			</register >
			<!-- [31] DigitalLibrary -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""DigitalLibrary"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1528038"" />
				<property name = ""Key"" value = ""DigitalLibrary"" />
				<property name = ""Name"" value = ""Digital Library"" />
				<property name = ""PathKey"" value = ""DigitalLibraryURL"" />
				<property name = ""Priority"" value = ""31"" />
			</register >
			<!-- [32] CLE On - Demand -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""CleOnDemand"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1528074"" />
				<property name = ""Key"" value = ""CleOnDemand"" />
				<property name = ""Name"" value = ""CLE On-Demand"" />
				<property name = ""PathKey"" value = ""CleOnDemandURL"" />
				<property name = ""Priority"" value = ""32"" />
			</register >
			<!-- [33] CaseMap -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""CaseMap"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1528016"" />
				<property name = ""Key"" value = ""CaseMap"" />
				<property name = ""Name"" value = ""CaseMap"" />
				<property name = ""PathKey"" value = ""CaseMapURL"" />
				<property name = ""Priority"" value = ""33"" />
			</register >
			<!-- [33] CaseMap canada -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""CaseMapCanada"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1536606"" />
				<property name = ""Key"" value = ""CaseMapCanada"" />
				<property name = ""Name"" value = ""CaseMapCanada"" />
				<property name = ""PathKey"" value = ""CaseMapCanadaURL"" />
				<property name = ""Priority"" value = ""33"" />
			</register >
			<!-- [34] IctOperationalTool -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""IctOperationalTool"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1531130"" />
				<property name = ""Key"" value = ""IctOperationalToolPath"" />
				<property name = ""Name"" value = ""IctOperationalTool"" />
				<property name = ""PathKey"" value = ""IctOperationalToolPath"" />
				<property name = ""Priority"" value = ""34"" />
			</register >
			<!-- [35] ASIC Analyser -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""ASICAnalyser"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1533054"" />
				<property name = ""Key"" value = ""ASICAnalyser"" />
				<property name = ""Name"" value = ""ASIC Analyser"" />
				<property name = ""PathKey"" value = ""ASICAnalyserURL"" />
				<property name = ""Priority"" value = ""35"" />
			</register >
			<!-- [36] TotalPatent One -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""TotalPatentOne"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1516823"" />
				<property name = ""Key"" value = ""TotalPatentOne"" />
				<property name = ""Name"" value = ""TotalPatent One®"" />
				<property name = ""PathKey"" value = ""TotalPatentOneURL"" />
				<property name = ""Priority"" value = ""36"" />
			</register >
			<!-- [37] Law360 Pulse -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""Law360Pulse"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1535706"" />
				<property name = ""Key"" value = ""Law360Pulse"" />
				<property name = ""Name"" value = ""Law360 Pulse"" />
				<property name = ""PathKey"" value = ""Law360PulseURL"" />
				<property name = ""Priority"" value = ""37"" />
			</register >
			<!-- [38] UKContext -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""UKContext"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1534729"" />
				<property name = ""Key"" value = ""ukcontext"" />
				<property name = ""Name"" value = ""UKContext"" />
				<property name = ""PathKey"" value = ""UKContextURL"" />
				<property name = ""Priority"" value = ""38"" />
			</register >
			<!-- [39] SmartPrecedents -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""SmartPrecedents"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1517145"" />
				<property name = ""Key"" value = ""smartprecedents"" />
				<property name = ""Name"" value = ""Lexis® Smart Precedents"" />
				<property name = ""PathKey"" value = ""SmartPrecedentsURL"" />
				<property name = ""Priority"" value = ""39"" />
			</register >
		<!-- [40] Patent Optimizer -->
		<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""PatentOptimizer"" >
			<lifetime type = ""singleton"" />
			<property name = ""Id"" value = ""1524888"" />
			<property name = ""Key"" value = ""PatentOptimizer"" />
			<property name = ""Name"" value = ""PatentOptimizer"" />
			<property name = ""PathKey"" value = ""PatentOptimizerURL"" />
			<property name = ""Priority"" value = ""40"" />
		</register >
			<!-- [41] PatentAdvisor -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""PatentAdvisor"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1538227"" />
				<property name = ""Key"" value = ""PatentAdvisor"" />
				<property name = ""Name"" value = ""PatentAdvisor"" />
				<property name = ""PathKey"" value = ""PatentAdvisorURL"" />
				<property name = ""Priority"" value = ""41"" />
			</register >
			<!-- [42] Practical Guidance Publishing -->
			<register type = ""LexisNexis.Navigation.ExternalProduct"" mapTo = ""LexisNexis.Navigation.ExternalProduct"" name = ""PracticalGuidancePublishing"" >
				<lifetime type = ""singleton"" />
				<property name = ""Id"" value = ""1540999"" />
				<property name = ""Key"" value = ""PracticalGuidancePublishing"" />
				<property name = ""Name"" value = ""PracticalGuidancePublishing"" />
				<property name = ""PathKey"" value = ""PracticalGuidancePublishingURL"" />
				<property name = ""Priority"" value = ""42"" />
			</register >

							</root>";

        // Parse the XML string into an XElement
        XElement root = XElement.Parse(xmlData);

        // Sort theregister elements by the name attribute
        IEnumerable<XElement> sortedElements = root.Elements("register")
            .OrderBy(e => (string)e.Attribute("name"));

        // Create a new XML document with the sorted elements
        XDocument sortedXml = new XDocument(new XElement("root", sortedElements));

        // Display the sorted XML
        Console.WriteLine(sortedXml.ToString());
    }
}
