using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace FERExcelAddIn
{
    public partial class API_653_Tank_Calcs : Form
    {
        private List<TextBox> heightInputs = new List<TextBox>();
        private List<TextBox> efficiencyInputs = new List<TextBox>();
        private const int MaxCourses = 8;
        private double E = 1.0;
        private bool _isUpdatingCombos = false;

        private static readonly Dictionary<string, Dictionary<string, object>> MaterialData =
     new Dictionary<string, Dictionary<string, object>>(StringComparer.OrdinalIgnoreCase)
     {
         ["A283-C"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 30000,
             ["Minimum Specified Tensile Strength (T)"] = 55000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 23600,
             ["Allowable Product Stress (S) - Upper Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 27000
         },
         ["A285-C"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 30000,
             ["Minimum Specified Tensile Strength (T)"] = 55000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 23600,
             ["Allowable Product Stress (S) - Upper Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 27000
         },
         ["A36"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 36000,
             ["Minimum Specified Tensile Strength (T)"] = 58000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 24900,
             ["Allowable Product Stress (S) - Upper Courses"] = 27400,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 27400,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 30100
         },
         ["A131-A, B, CS"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 34000,
             ["Minimum Specified Tensile Strength (T)"] = 58000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 24900,
             ["Allowable Product Stress (S) - Upper Courses"] = 27400,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 27400,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 30100
         },
         ["A131-EH 36"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 51000,
             ["Minimum Specified Tensile Strength (T)"] = 71000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30500,
             ["Allowable Product Stress (S) - Upper Courses"] = 33500,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33500,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36800
         },
         ["A573-58"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 32000,
             ["Minimum Specified Tensile Strength (T)"] = 58000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 24900,
             ["Allowable Product Stress (S) - Upper Courses"] = 27400,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 27400,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 28800
         },
         ["A573-65"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 35000,
             ["Minimum Specified Tensile Strength (T)"] = 65000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 27900,
             ["Allowable Product Stress (S) - Upper Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 31500
         },
         ["A573-70"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 42000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30000,
             ["Allowable Product Stress (S) - Upper Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["A516-55"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 30000,
             ["Minimum Specified Tensile Strength (T)"] = 55000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 23800,
             ["Allowable Product Stress (S) - Upper Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 27000
         },
         ["A516-60"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 32000,
             ["Minimum Specified Tensile Strength (T)"] = 60000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 25600,
             ["Allowable Product Stress (S) - Upper Courses"] = 28200,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 28200,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 28800
         },
         ["A516-65"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 35000,
             ["Minimum Specified Tensile Strength (T)"] = 65000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 27900,
             ["Allowable Product Stress (S) - Upper Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 31500
         },
         ["A516-70"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 38000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 25500,
             ["Allowable Product Stress (S) - Upper Courses"] = 25500,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 34200
         },
         ["A662-C"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 40000,
             ["Minimum Specified Tensile Strength (T)"] = 65000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 27900,
             ["Allowable Product Stress (S) - Upper Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 33700
         },
         ["A682-C"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 43000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 25500,
             ["Allowable Product Stress (S) - Upper Courses"] = 25500,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["A637-Class 1"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30000,
             ["Allowable Product Stress (S) - Upper Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["A637-Class 2"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 60000,
             ["Minimum Specified Tensile Strength (T)"] = 80000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 34300,
             ["Allowable Product Stress (S) - Upper Courses"] = 37800,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 37800,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 41500
         },
         ["A633-C, D"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30000,
             ["Allowable Product Stress (S) - Upper Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["A678-A"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30000,
             ["Allowable Product Stress (S) - Upper Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["A678-B"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 60000,
             ["Minimum Specified Tensile Strength (T)"] = 80000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 34300,
             ["Allowable Product Stress (S) - Upper Courses"] = 37800,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 37800,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 41500
         },
         ["A737-B"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30000,
             ["Allowable Product Stress (S) - Upper Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["A841"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30000,
             ["Allowable Product Stress (S) - Upper Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["A10"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 30000,
             ["Minimum Specified Tensile Strength (T)"] = 55000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 23600,
             ["Allowable Product Stress (S) - Upper Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 27000
         },
         ["A7"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 33000,
             ["Minimum Specified Tensile Strength (T)"] = 60000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 25700,
             ["Allowable Product Stress (S) - Upper Courses"] = 28300,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 28300,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 29700
         },
         ["A442-56"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 30000,
             ["Minimum Specified Tensile Strength (T)"] = 55000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 23600,
             ["Allowable Product Stress (S) - Upper Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 27000
         },
         ["A442-60"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 32000,
             ["Minimum Specified Tensile Strength (T)"] = 60000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 25600,
             ["Allowable Product Stress (S) - Upper Courses"] = 28200,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 28200,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 28800
         },
         ["G40.21, 38W"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 38000,
             ["Minimum Specified Tensile Strength (T)"] = 60000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 25700,
             ["Allowable Product Stress (S) - Upper Courses"] = 28300,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 28300,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 31100
         },
         ["G40.21, 44W (Note 7)"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 44000,
             ["Minimum Specified Tensile Strength (T)"] = 65000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 27900,
             ["Allowable Product Stress (S) - Upper Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 33700
         },
         ["G40.21, 44W (Note 8)"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 44000,
             ["Minimum Specified Tensile Strength (T)"] = 64000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 27400,
             ["Allowable Product Stress (S) - Upper Courses"] = 30200,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 33200
         },
         ["G40.21, 50W"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 65000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 27900,
             ["Allowable Product Stress (S) - Upper Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 33700
         },
         ["G40.21, 50WT (Note 7)"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 70000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 30000,
             ["Allowable Product Stress (S) - Upper Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 33000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 36300
         },
         ["G40.21, 50WT (Note 8)"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 50000,
             ["Minimum Specified Tensile Strength (T)"] = 65000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 27900,
             ["Allowable Product Stress (S) - Upper Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 30700,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 33700
         },
         ["Unknown Material Specification and Grade"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = 30000,
             ["Minimum Specified Tensile Strength (T)"] = 55000,
             ["Allowable Product Stress (S) - Lower Two Courses"] = 23600,
             ["Allowable Product Stress (S) - Upper Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 26000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 27000
         },
         ["Riveted Tanks: A7, A9 or A10"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = "NA",
             ["Minimum Specified Tensile Strength (T)"] = "NA",
             ["Allowable Product Stress (S) - Lower Two Courses"] = 21000,
             ["Allowable Product Stress (S) - Upper Courses"] = 21000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 21000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 21000
         },
         ["Riveted Tanks: Known"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = "Y",
             ["Minimum Specified Tensile Strength (T)"] = "T",
             ["Allowable Product Stress (S) - Lower Two Courses"] = "Note 4",
             ["Allowable Product Stress (S) - Upper Courses"] = "Note 4",
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = "Note 4",
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = "Note 4"
         },
         ["Riveted Tanks: Unknown"] = new Dictionary<string, object>
         {
             ["Minimum Specified Yield Stress (Y)"] = "NA",
             ["Minimum Specified Tensile Strength (T)"] = "NA",
             ["Allowable Product Stress (S) - Lower Two Courses"] = 21000,
             ["Allowable Product Stress (S) - Upper Courses"] = 21000,
             ["Allowable Hydrostatic Test Stress (St) - Lower Two Courses"] = 21000,
             ["Allowable Hydrostatic Test Stress (St) - Upper Courses"] = 21000
         }
     };
        private static readonly Dictionary<string, Dictionary<string, object>> JointEfficiencyData =
    new Dictionary<string, Dictionary<string, object>>(StringComparer.OrdinalIgnoreCase)
    {
        // Welded Joints from API 653 Table 4.2
        ["API 650 | 7th+ Ed (1980-Present) | Butt | Basic Standard"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 650",
            ["Edition"] = "7th and Later (1980-Present)",
            ["JointType"] = "Butt",
            ["Efficiency"] = 1.00,
            ["Limits"] = "Basic Standard",
            ["Notes"] = "Basic Standard Joint Efficiency"
        },
        ["API 650 | 7th+ Ed (1980-Present) | Butt | Annex A Spot RT"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 650",
            ["Edition"] = "7th and Later (1980-Present)",
            ["JointType"] = "Butt",
            ["Efficiency"] = 0.85,
            ["Limits"] = "Annex A Spot RT",
            ["Notes"] = "Radiographic testing (RT) required."
        },
        ["API 650 | 7th+ Ed (1980-Present) | Butt | Annex A No RT"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 650",
            ["Edition"] = "7th and Later (1980-Present)",
            ["JointType"] = "Butt",
            ["Efficiency"] = 0.70,
            ["Limits"] = "Annex A No RT",
            ["Notes"] = "No radiographic testing."
        },
        ["API 650 | 1st-6th Ed (1961-1978) | Butt | Basic Standard"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 650",
            ["Edition"] = "1st to 6th (1961-1978)",
            ["JointType"] = "Butt",
            ["Efficiency"] = 0.85,
            ["Limits"] = "Basic Standard",
            ["Notes"] = ""
        },
        ["API 650 | 1st-6th Ed (1961-1978) | Butt | Annexes D or G"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 650",
            ["Edition"] = "1st to 6th (1961-1978)",
            ["JointType"] = "Butt",
            ["Efficiency"] = 1.00,
            ["Limits"] = "Annexes D or G",
            ["Notes"] = "Special design or materials."
        },
        ["API 12C | 14th-15th Ed (1957-1958) | Butt"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 12C",
            ["Edition"] = "14th and 15th (1957-1958)",
            ["JointType"] = "Butt",
            ["Efficiency"] = 0.85,
            ["Limits"] = "",
            ["Notes"] = ""
        },
        ["API 12C | 3rd-13th Ed (1940-1956) | Lap (a)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 12C",
            ["Edition"] = "3rd to 13th (1940-1956)",
            ["JointType"] = "Lap (a)",
            ["Efficiency"] = 0.75,
            ["Limits"] = "3/8 in. max. thickness (t)",
            ["Notes"] = "Full double lap-welded."
        },
        ["API 12C | 3rd-13th Ed (1940-1956) | Butt (c)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 12C",
            ["Edition"] = "3rd to 13th (1940-1956)",
            ["JointType"] = "Butt (c)",
            ["Efficiency"] = 0.85,
            ["Limits"] = "",
            ["Notes"] = "Single butt-welded with back-up bar."
        },
        ["API 12C | 1st-2nd Ed (1936-1939) | Lap (a)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 12C",
            ["Edition"] = "1st and 2nd (1936-1939)",
            ["JointType"] = "Lap (a)",
            ["Efficiency"] = 0.70,
            ["Limits"] = "7/16 in. max. t",
            ["Notes"] = "Full double lap-welded."
        },
        ["API 12C | 1st-2nd Ed (1936-1939) | Lap (b)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 12C",
            ["Edition"] = "1st and 2nd (1936-1939)",
            ["JointType"] = "Lap (b)",
            ["Efficiency"] = "0.50 + k/5",
            ["Limits"] = "1/4 in. max. t",
            ["Notes"] = "Full fillet weld with >=25% intermittent full fillet opposite side; k = % intermittent weld (decimal)."
        },
        ["API 12C | 1st-2nd Ed (1936-1939) | Butt (c)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "API 12C",
            ["Edition"] = "1st and 2nd (1936-1939)",
            ["JointType"] = "Butt (c)",
            ["Efficiency"] = 0.85,
            ["Limits"] = "",
            ["Notes"] = "Single butt-welded with back-up bar."
        },
        ["Unknown | Lap (a)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Unknown",
            ["Edition"] = "",
            ["JointType"] = "Lap (a)",
            ["Efficiency"] = 0.70,
            ["Limits"] = "7/16 in. max. t",
            ["Notes"] = "Full double lap-welded."
        },
        ["Unknown | Lap (b)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Unknown",
            ["Edition"] = "",
            ["JointType"] = "Lap (b)",
            ["Efficiency"] = "0.50 + k/5",
            ["Limits"] = "1/4 in. max. t",
            ["Notes"] = "As above."
        },
        ["Unknown | Butt"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Unknown",
            ["Edition"] = "",
            ["JointType"] = "Butt",
            ["Efficiency"] = 0.70,
            ["Limits"] = "",
            ["Notes"] = ""
        },
        ["Unknown | Lap (d)"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Unknown",
            ["Edition"] = "",
            ["JointType"] = "Lap (d)",
            ["Efficiency"] = 0.35,
            ["Limits"] = "",
            ["Notes"] = "Single lap-welded only."
        },

        // Riveted Joints from API 653 Table 4.3 (assumed from user data)
        ["Riveted | Lap | 1 Row"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Lap",
            ["Edition"] = "1 Row",
            ["Efficiency"] = 0.45,
            ["Limits"] = "",
            ["Notes"] = ""
        },
        ["Riveted | Lap | 2 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Lap",
            ["Edition"] = "2 Rows",
            ["Efficiency"] = 0.60,
            ["Limits"] = "",
            ["Notes"] = ""
        },
        ["Riveted | Lap | 3 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Lap",
            ["Edition"] = "3 Rows",
            ["Efficiency"] = 0.70,
            ["Limits"] = "",
            ["Notes"] = ""
        },
        ["Riveted | Lap | 4 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Lap",
            ["Edition"] = "4 Rows",
            ["Efficiency"] = 0.75,
            ["Limits"] = "",
            ["Notes"] = ""
        },
        ["Riveted | Butt | 2 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Butt",
            ["Edition"] = "2 Rows",
            ["Efficiency"] = 0.75,
            ["Limits"] = "",
            ["Notes"] = "All butt joints listed have butt straps on both inside and outside. Number of rows on each side of joint center line."
        },
        ["Riveted | Butt | 3 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Butt",
            ["Edition"] = "3 Rows",
            ["Efficiency"] = 0.85,
            ["Limits"] = "",
            ["Notes"] = "All butt joints listed have butt straps on both inside and outside. Number of rows on each side of joint center line."
        },
        ["Riveted | Butt | 4 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Butt",
            ["Edition"] = "4 Rows",
            ["Efficiency"] = 0.90,
            ["Limits"] = "",
            ["Notes"] = "All butt joints listed have butt straps on both inside and outside. Number of rows on each side of joint center line."
        },
        ["Riveted | Butt | 5 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Butt",
            ["Edition"] = "5 Rows",
            ["Efficiency"] = 0.91,
            ["Limits"] = "",
            ["Notes"] = "All butt joints listed have butt straps on both inside and outside. Number of rows on each side of joint center line."
        },
        ["Riveted | Butt | 6 Rows"] = new Dictionary<string, object>
        {
            ["Grouping"] = "Riveted",
            ["JointType"] = "Butt",
            ["Edition"] = "6 Rows",
            ["Efficiency"] = 0.92,
            ["Limits"] = "",
            ["Notes"] = "All butt joints listed have butt straps on both inside and outside. Number of rows on each side of joint center line."
        }
    };

        private void PopulateStandardDropdown()
        {
            _isUpdatingCombos = true;
            var standards = JointEfficiencyData.Values
                .Select(props => props["Grouping"].ToString())
                .Distinct()
                .ToList();

            // Custom sort: API 650 first, then the rest alphabetically
            var customOrder = new List<string> { "API 650" };
            standards = standards.OrderBy(s => {
                int index = customOrder.IndexOf(s);
                return index == -1 ? int.MaxValue : index;
            }).ThenBy(s => s).ToList();

            cmbStandard.DataSource = standards;
            _isUpdatingCombos = false;
            cmbStandard.SelectedIndex = -1;
            cmbStandard.SelectedIndex = 0;
        }

        private void cmbStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingCombos || cmbStandard.SelectedItem == null) return;

            _isUpdatingCombos = true;
            string selectedStandard = cmbStandard.SelectedItem.ToString();

            // Clear all downstream dropdowns
            cmbEdition.DataSource = null;
            cmbJointType.DataSource = null;
            cmbApplicability.DataSource = null;
            cmbNumRivets.DataSource = null;

            if (selectedStandard == "Riveted")
            {
                lblEdition.Visible = false;
                cmbEdition.Visible = false;
                lblLimits.Visible = false;
                cmbApplicability.Visible = false;
                lblNumRivets.Visible = true;
                cmbNumRivets.Visible = true;

                var jointTypes = JointEfficiencyData.Values
                    .Where(props => props["Grouping"].ToString() == selectedStandard)
                    .Select(props => props["JointType"].ToString())
                    .Distinct()
                    .OrderBy(s => s)
                    .ToList();
                cmbJointType.DataSource = jointTypes;
            }
            else
            {
                lblEdition.Visible = true;
                cmbEdition.Visible = true;
                lblLimits.Visible = true;
                cmbApplicability.Visible = true;
                lblNumRivets.Visible = false;
                cmbNumRivets.Visible = false;

                var editions = JointEfficiencyData.Values
                    .Where(props => props["Grouping"].ToString() == selectedStandard)
                    .Select(props => props["Edition"].ToString())
                    .Distinct()
                    .OrderByDescending(s => s) // Sort by latest edition first
                    .ToList();
                cmbEdition.DataSource = editions;
            }
            _isUpdatingCombos = false;

            // Manually trigger the next event in the chain
            if (selectedStandard == "Riveted")
            {
                if (cmbJointType.Items.Count > 0) cmbJointType.SelectedIndex = 0;
            }
            else
            {
                if (cmbEdition.Items.Count > 0) cmbEdition.SelectedIndex = 0;
            }
        }

        private void cmbEdition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingCombos || cmbEdition.SelectedItem == null) return;

            _isUpdatingCombos = true;
            string selectedStandard = cmbStandard.SelectedItem.ToString();
            string selectedEdition = cmbEdition.SelectedItem.ToString();

            cmbJointType.DataSource = null;
            cmbApplicability.DataSource = null;

            var jointTypes = JointEfficiencyData.Values
                .Where(props => props["Grouping"].ToString() == selectedStandard &&
                              props["Edition"].ToString() == selectedEdition)
                .Select(props => props["JointType"].ToString())
                .Distinct()
                .OrderBy(s => s)
                .ToList();

            cmbJointType.DataSource = jointTypes;
            _isUpdatingCombos = false;
            if (cmbJointType.Items.Count > 0) cmbJointType.SelectedIndex = 0;
        }

        private void cmbJointType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingCombos || cmbJointType.SelectedItem == null) return;

            string selectedJointTypeStr = cmbJointType.SelectedItem.ToString();

            // Show/hide k-factor controls
            bool needsKFactor = selectedJointTypeStr.Contains("Lap (b)");
            lblKFactor.Visible = needsKFactor;
            txtKFactor.Visible = needsKFactor;
            if (needsKFactor)
            {
                // Set a default value if the box is empty, otherwise leave the user's value.
                if (string.IsNullOrWhiteSpace(txtKFactor.Text))
                {
                    txtKFactor.Text = "0.0";
                }
            }

            _isUpdatingCombos = true;
            string selectedStandard = cmbStandard.SelectedItem.ToString();
            string selectedJointType = cmbJointType.SelectedItem.ToString();

            cmbApplicability.DataSource = null;
            cmbNumRivets.DataSource = null;

            if (selectedStandard == "Riveted")
            {
                var rivetRows = JointEfficiencyData.Values
                    .Where(props => props["Grouping"].ToString() == selectedStandard &&
                                  props["JointType"].ToString() == selectedJointType)
                    .Select(props => props["Edition"].ToString()) // "Edition" holds the rivet row info
                    .Distinct()
                    .OrderBy(s => s)
                    .ToList();
                cmbNumRivets.DataSource = rivetRows;
            }
            else
            {
                string selectedEdition = cmbEdition.SelectedItem.ToString();
                var limits = JointEfficiencyData.Values
                    .Where(props => props["Grouping"].ToString() == selectedStandard &&
                                    props["Edition"].ToString() == selectedEdition &&
                                    props["JointType"].ToString() == selectedJointType)
                    .Select(props => props["Limits"].ToString())
                    .Distinct()
                    .OrderBy(s => s)
                    .ToList();

                cmbApplicability.DataSource = limits;
            }

            _isUpdatingCombos = false;
            if (selectedStandard == "Riveted")
            {
                if (cmbNumRivets.Items.Count > 0) cmbNumRivets.SelectedIndex = 0;
            }
            else
            {
                if (cmbApplicability.Items.Count > 0) cmbApplicability.SelectedIndex = 0;
            }
        }

        private void RecalculateEfficiency()
        {
            if (_isUpdatingCombos) return;

            string selectedStandard = cmbStandard.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedStandard)) return;

            Dictionary<string, object> finalSelection = null;

            if (selectedStandard == "Riveted")
            {
                string selectedJointType = cmbJointType.SelectedItem?.ToString();
                string selectedRivetRows = cmbNumRivets.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedJointType) || string.IsNullOrEmpty(selectedRivetRows)) return;

                finalSelection = JointEfficiencyData.Values
                    .FirstOrDefault(props => props["Grouping"].ToString() == selectedStandard &&
                                           props["JointType"].ToString() == selectedJointType &&
                                           props["Edition"].ToString() == selectedRivetRows);
            }
            else
            {
                string selectedEdition = cmbEdition.SelectedItem?.ToString();
                string selectedJointType = cmbJointType.SelectedItem?.ToString();
                string selectedApplicability = cmbApplicability.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(selectedEdition) || string.IsNullOrEmpty(selectedJointType) || string.IsNullOrEmpty(selectedApplicability)) return;

                finalSelection = JointEfficiencyData.Values
                    .FirstOrDefault(props => props["Grouping"].ToString() == selectedStandard &&
                                             props["Edition"].ToString() == selectedEdition &&
                                             props["JointType"].ToString() == selectedJointType &&
                                             props["Limits"].ToString() == selectedApplicability);
            }

            if (finalSelection != null)
            {
                UpdateFinalSelection(finalSelection, null, null);
            }
        }

        private void cmbApplicability_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingCombos) return;
            RecalculateEfficiency();
        }

        private void cmbNumRivets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isUpdatingCombos) return;
            RecalculateEfficiency();
        }

        private void txtKFactor_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!double.TryParse(txtKFactor.Text, out double k) || k < 0 || k > 1)
            {
                MessageBox.Show("Invalid k-factor. Please enter a decimal value between 0.0 and 1.0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true; // Prevent the user from leaving the control
            }
        }

        private void txtKFactor_Validated(object sender, EventArgs e)
        {
            RecalculateEfficiency();
        }

        private void UpdateFinalSelection(Dictionary<string, object> jointProps, object sender, EventArgs e)
        {
            object efficiencyValue = jointProps["Efficiency"];
            string notes = jointProps["Notes"].ToString();

            lblEfficiencyValue.Text = $"Selected Efficiency: {efficiencyValue}";
            lblEfficiencyDescription.Text = $"Notes: {notes}";

            if (efficiencyValue is double)
            {
                E = (double)efficiencyValue;
            }
            else if (efficiencyValue is string)
            {
                E = ParseEfficiencyFormula(efficiencyValue.ToString());
            }

            foreach (var txtEff in efficiencyInputs)
            {
                txtEff.Text = E.ToString("0.00");
            }
            CalculateAllCourses(sender, e);
        }

        private double ParseEfficiencyFormula(string formula)
        {
            if (formula.Contains("k"))
            {
                // If k-factor is needed, try to parse it. Default to 0 if parsing fails.
                // The Validating event should prevent bad data, but this is a safe fallback.
                double.TryParse(txtKFactor.Text, out double k);
                return 0.50 + k / 5.0;
            }

            if (double.TryParse(formula, out double result))
            {
                return result;
            }

            return 0.85; // Default fallback for other potential string formulas
        }

        public API_653_Tank_Calcs()
        {
            InitializeComponent();

            numCourses.Maximum = MaxCourses;
            btnGenerateHeightInputs.Click += GenerateHeightInputs;
            btnCalculate.Click += CalculateAllCourses;
            btnCalculateHydro.Click += btnCalculateHydro_Click;
            btnSolveForH.Click += btnSolveForH_Click;

            InitializeMaterialDropdown();

            // Wire up events AFTER initial population
            cmbMaterial.SelectedIndexChanged += MaterialSelectionChanged;
            cmbStandard.SelectedIndexChanged += cmbStandard_SelectedIndexChanged;
            cmbEdition.SelectedIndexChanged += cmbEdition_SelectedIndexChanged;
            cmbJointType.SelectedIndexChanged += cmbJointType_SelectedIndexChanged;
            cmbApplicability.SelectedIndexChanged += cmbApplicability_SelectedIndexChanged;
            cmbNumRivets.SelectedIndexChanged += cmbNumRivets_SelectedIndexChanged;
            btnCalculateMrt.Click += btnCalculateMrt_Click;
            btnCalculateCriticalZone.Click += btnCalculateCriticalZone_Click;
            btnCalculateAnnularPlate.Click += btnCalculateAnnularPlate_Click;
            btnCalculateLocalized.Click += btnCalculateLocalized_Click;
            btnCalculateSettlement.Click += btnCalculateSettlement_Click;
            chkBottomCoated.CheckedChanged += chkBottomCoated_CheckedChanged;
            txtKFactor.Validating += txtKFactor_Validating;
            txtKFactor.Validated += txtKFactor_Validated;

            InitializeSettlementTab();
            InitializeMrtDropdown();
            InitializeAnnularPlateTab();
            InitializeTooltips();

            // Set defaults after wiring events
            SetFormDefaults();
        }

        private void SetFormDefaults()
        {
            // Set Material
            cmbMaterial.SelectedItem = "A516-70";

            // Set Joint Efficiency. Setting the top-level item will trigger the event
            // cascade to populate and set the defaults for the child dropdowns.
            // The event handlers are already configured to select the first item in each
            // list, which corresponds to the desired defaults.
            cmbStandard.SelectedItem = "API 650";
        }

        private void InitializeMaterialDropdown()
        {
            // Add all material names to the dropdown
            cmbMaterial.Items.Clear();
            var materialNames = MaterialData.Keys.ToList();
            cmbMaterial.DataSource = materialNames;

            // Populate standards after materials
            PopulateStandardDropdown();
        }
        private void MaterialSelectionChanged(object sender, EventArgs e)
        {
            if (cmbMaterial.SelectedItem == null) return;

            string selectedMaterial = cmbMaterial.SelectedItem.ToString();
            if (MaterialData.TryGetValue(selectedMaterial, out var materialProps))
            {
                // Update the yield and tensile strength fields
                txtYieldStrength.Text = materialProps["Minimum Specified Yield Stress (Y)"].ToString();
                txtTensileStrength.Text = materialProps["Minimum Specified Tensile Strength (T)"].ToString();
            }
        }
        private void GenerateHeightInputs(object sender, EventArgs e)
        {
            panelHeightInputs.Controls.Clear();
            heightInputs.Clear();
            efficiencyInputs.Clear();

            int numberOfCourses = (int)numCourses.Value;
            int yPos = 0;
            int verticalSpacing = 25;
            int inputWidth = 40;
            int rightMargin = 20;
            int unitLabelWidth = 25;
            int efficiencyLabelWidth = 30;
            int efficiencyInputWidth = 40;
            int maxLabelWidth = panelHeightInputs.Width - inputWidth - unitLabelWidth - efficiencyLabelWidth - efficiencyInputWidth - rightMargin - 15;


            // Add a label to display total height at the bottom
            Label lblTotalHeightDisplay = new Label
            {
                Text = "Total Height: 0.00 ft",
                Location = new Point(10, yPos + (numberOfCourses * verticalSpacing) + 10),
                AutoSize = true,
                Font = new Font(this.Font, FontStyle.Bold),
                Name = "lblTotalHeightDisplay"
            };
            panelHeightInputs.Controls.Add(lblTotalHeightDisplay);

            ToolTip courseToolTip = new ToolTip();

            for (int i = 1; i <= numberOfCourses; i++)
            {
                var lbl = new Label
                {
                    Text = $"Shell Course {i} Height:",
                    Location = new Point(10, yPos),
                    Width = maxLabelWidth,
                    Height = 20
                };

                var txtHeight = new TextBox
                {
                    Location = new Point(lbl.Right + 5, yPos),
                    Width = inputWidth,
                    Height = 20,
                    MaxLength = 4,
                    Tag = i,
                    TextAlign = HorizontalAlignment.Right,
                    TabIndex = i - 1
                };

                txtHeight.TextChanged += CourseHeight_TextChanged;
                txtHeight.Validating += TxtCourseHeight_Validating;

                var unitLbl = new Label
                {
                    Text = "ft",
                    Location = new Point(txtHeight.Right + 2, yPos),
                    Width = unitLabelWidth,
                    Height = 20
                };

                var lblEff = new Label
                {
                    Text = "E:",
                    Location = new Point(unitLbl.Right + 10, yPos),
                    Width = efficiencyLabelWidth,
                    Height = 20
                };

                var txtEff = new TextBox
                {
                    Location = new Point(lblEff.Right + 5, yPos),
                    Width = efficiencyInputWidth,
                    Height = 20,
                    MaxLength = 4,
                    Text = this.E.ToString("0.00"),
                    Tag = i,
                    TextAlign = HorizontalAlignment.Right,
                    TabIndex = i - 1 + numberOfCourses
                };

                txtEff.Validating += TxtEfficiency_Validating;

                if (i == 1)
                {
                    courseToolTip.SetToolTip(lbl, "This is the bottom course of the tank");
                    lbl.Font = new Font(this.Font, FontStyle.Bold);
                }

                panelHeightInputs.Controls.Add(lbl);
                panelHeightInputs.Controls.Add(txtHeight);
                panelHeightInputs.Controls.Add(unitLbl);
                panelHeightInputs.Controls.Add(lblEff);
                panelHeightInputs.Controls.Add(txtEff);
                heightInputs.Add(txtHeight);
                efficiencyInputs.Add(txtEff);
                yPos += verticalSpacing;
            }
        }

        private void CourseHeight_TextChanged(object sender, EventArgs e)
        {
            double totalHeight = 0;
            bool allValid = true;

            foreach (var input in heightInputs)
            {
                if (string.IsNullOrEmpty(input.Text))
                {
                    allValid = false;
                    break;
                }

                if (double.TryParse(input.Text, out double height))
                {
                    totalHeight += height;
                }
                else
                {
                    allValid = false;
                    break;
                }
            }

            // Find the total height label (we added it in GenerateHeightInputs)
            foreach (Control control in panelHeightInputs.Controls)
            {
                if (control.Name == "lblTotalHeightDisplay")
                {
                    if (allValid)
                    {
                        control.Text = $"Total Height: {totalHeight.ToString("0.00")} ft";
                        control.ForeColor = SystemColors.ControlText;
                    }
                    else
                    {
                        control.Text = "Total Height: (complete all fields)";
                        control.ForeColor = Color.Gray;
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Calculates the minimum required shell thickness for each course and populates the result grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateAllCourses(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                if (heightInputs.Count == 0)
                {
                    MessageBox.Show("Please generate height inputs first");
                    return;
                }

                if (cmbMaterial.SelectedItem == null)
                {
                    MessageBox.Show("Please select a material");
                    return;
                }

                string selectedMaterial = cmbMaterial.SelectedItem.ToString();
                if (!MaterialData.TryGetValue(selectedMaterial, out var materialProps))
                {
                    MessageBox.Show("Invalid material selected");
                    return;
                }

                resultGrid.Rows.Clear();

                // Parse input values
                double D = double.Parse(txtDiameter.Text);
                double G = double.Parse(txtSpecificGravity.Text);
                double ca = double.Parse(txtCorrosionAllowance.Text);

                // Per API 653, T shall be the smaller of specified T or 80,000 psi
                double T_material = Convert.ToDouble(materialProps["Minimum Specified Tensile Strength (T)"]);
                if (T_material > 80000) T_material = 80000;

                double Y_material = Convert.ToDouble(materialProps["Minimum Specified Yield Stress (Y)"]);

                int totalCourses = heightInputs.Count;
                bool fallbackUsed = false;

                // First, calculate total liquid height
                double totalLiquidHeight = 0;
                foreach (var heightInput in heightInputs)
                {
                    if (double.TryParse(heightInput.Text, out double h))
                    {
                        totalLiquidHeight += h;
                    }
                    else
                    {
                        MessageBox.Show("Invalid height value entered.");
                        return;
                    }
                }

                double heightFromBottom = 0;
                // Loop from bottom course to top course
                for (int i = 0; i < totalCourses; i++)
                {
                    int courseNumber = i + 1;
                    if (!double.TryParse(heightInputs[i].Text, out double courseHeight) ||
                        !double.TryParse(efficiencyInputs[i].Text, out double courseE))
                    {
                        MessageBox.Show($"Invalid input for Course {courseNumber}");
                        return;
                    }

                    double H_course = totalLiquidHeight - heightFromBottom;
                    if (H_course < 1.0) H_course = 1.0; // Min height for H-1 calc is 1 ft.

                    string stressBasis;
                    double S_unefficiencied;
                    string courseType = (courseNumber <= 2) ? "Lower" : "Upper";
                    string stressKey = (courseNumber <= 2) ? "Allowable Product Stress (S) - Lower Two Courses" : "Allowable Product Stress (S) - Upper Courses";

                    string efficiencyString = courseE.ToString("0.00");
                    if (lblKFactor.Visible)
                    {
                        efficiencyString = $"(0.50 + {txtKFactor.Text}/5)";
                    }

                    // New logic: Prioritize Table 4.1 (MaterialData)
                    if (materialProps.ContainsKey(stressKey) && double.TryParse(materialProps[stressKey].ToString(), out S_unefficiencied))
                    {
                        stressBasis = $"Table 4.1 ({S_unefficiencied:F0}) × {efficiencyString} ({courseType})";
                    }
                    else // Fallback to first principles
                    {
                        fallbackUsed = true;
                        double s_yield_based = (2.0 / 3.0) * Y_material;
                        double s_tensile_based = (2.0 / 5.0) * T_material;

                        if (s_tensile_based <= s_yield_based)
                        {
                            S_unefficiencied = s_tensile_based;
                            stressBasis = $"Calculated: 2/5×T×E = 2/5×{T_material:F0}×{efficiencyString} (governing)";
                        }
                        else
                        {
                            S_unefficiencied = s_yield_based;
                            stressBasis = $"Calculated: 2/3×Y×E = 2/3×{Y_material:F0}×{efficiencyString}";
                        }
                    }

                    double allowableStress = S_unefficiencied * courseE;
                    // Apply "double E" as per user's step-by-step calculation
                    double t_calculated = (2.6 * D * (H_course - 1) * G) / (allowableStress * courseE);
                    double t_final = t_calculated + ca;
                    double t_rounded = Math.Round(t_final, 3); // Round to 3 decimal places

                    string verificationFormula = $"((2.6 * ({H_course:F2}ft - 1) * {D:F2}ft * {G}) / ({allowableStress:F0}psi * {courseE:F2})) + {ca:F4}\" = {t_rounded:F3}\"";

                    resultGrid.Rows.Add(
                        courseNumber,
                        courseHeight.ToString("0.00"),
                        t_rounded.ToString("0.000"),
                        allowableStress.ToString("0"),
                        stressBasis,
                        verificationFormula
                    );

                    heightFromBottom += courseHeight;
                }

                if (fallbackUsed)
                {
                    MessageBox.Show("Material not in Table 4.1 - Using calculated stress values.", "Fallback Calculation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Prepare the hydroResultGrid for user input
                hydroResultGrid.Rows.Clear();
                foreach (DataGridViewRow row in resultGrid.Rows)
                {
                    if (row.IsNewRow) continue;
                    hydroResultGrid.Rows.Add(row.Cells["CourseNumber"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in calculation: {ex.Message}");
            }
        }

        /// <summary>
        /// Calculates the maximum allowable hydrostatic test height for each course and populates the hydrotest result grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateHydro_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                if (cmbMaterial.SelectedItem == null)
                {
                    MessageBox.Show("Please select a material first.");
                    return;
                }

                if (resultGrid.Rows.Count == 0)
                {
                    MessageBox.Show("Please calculate minimum thickness first.");
                    return;
                }

                string selectedMaterial = cmbMaterial.SelectedItem.ToString();
                if (!MaterialData.TryGetValue(selectedMaterial, out var materialProps))
                {
                    MessageBox.Show("Invalid material selected");
                    return;
                }

                double D = double.Parse(txtDiameter.Text);
                double ca = double.Parse(txtCorrosionAllowance.Text);

                foreach (DataGridViewRow row in hydroResultGrid.Rows)
                {
                    if (row.IsNewRow) continue;

                    int courseNumber = Convert.ToInt32(row.Cells["HydroCourseNumber"].Value);

                    if (row.Cells["ActualThickness"].Value == null ||
                        !double.TryParse(row.Cells["ActualThickness"].Value.ToString(), out double t_actual))
                    {
                        MessageBox.Show($"Please enter a valid actual thickness for Course {courseNumber}.");
                        return;
                    }

                    // Per user report, check if actual thickness is sufficient
                    double t_min_required = double.Parse(resultGrid.Rows[row.Index].Cells["MinThickness"].Value.ToString());
                    if (t_actual < t_min_required)
                    {
                        MessageBox.Show($"Actual thickness for Course {courseNumber} ({t_actual:F4}\") is less than the minimum required thickness ({t_min_required:F4}\").", "Thickness Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        row.Cells["AllowableHt"].Value = "Error";
                        continue;
                    }

                    double courseE = double.Parse(efficiencyInputs[courseNumber - 1].Text);

                    // Per user request, use Product Design Stress for Hydrotest calculation.
                    double S_product = double.Parse(resultGrid.Rows[row.Index].Cells["AllowableStress"].Value.ToString());

                    // Note: Per user report, t_actual is used directly, without subtracting corrosion allowance for hydrotest height.
                    double t_available = t_actual;

                    // Ht = (S * E * t_available) / (2.6 * D)
                    double Ht = (S_product * courseE * t_available) / (2.6 * D);

                    row.Cells["AllowableHt"].Value = Ht.ToString("0.00");

                    // Verification Formula
                    string hydroVerificationFormula = $"({t_available:F3}\" * {S_product:F0}psi * {courseE:F2}) / (2.6 * {D:F2}ft) = {Ht:F2}ft";
                    var verificationCell = row.Cells["HydrotestVerification"];

                    verificationCell.Value = hydroVerificationFormula;
                    verificationCell.Style.ForeColor = Color.Black;
                    verificationCell.ToolTipText = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in hydrostatic calculation: {ex.Message}");
            }
        }

        /// <summary>
        /// Calculates the maximum allowable liquid height for each course based on its actual thickness and populates the hydrotest result grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSolveForH_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                if (cmbMaterial.SelectedItem == null)
                {
                    MessageBox.Show("Please select a material first.");
                    return;
                }

                if (resultGrid.Rows.Count == 0)
                {
                    MessageBox.Show("Please calculate minimum thickness first.");
                    return;
                }

                string selectedMaterial = cmbMaterial.SelectedItem.ToString();
                if (!MaterialData.TryGetValue(selectedMaterial, out var materialProps))
                {
                    MessageBox.Show("Invalid material selected");
                    return;
                }

                double D = double.Parse(txtDiameter.Text);
                double G = double.Parse(txtSpecificGravity.Text);
                double ca = double.Parse(txtCorrosionAllowance.Text);

                foreach (DataGridViewRow row in hydroResultGrid.Rows)
                {
                    if (row.IsNewRow) continue;

                    int courseNumber = Convert.ToInt32(row.Cells["HydroCourseNumber"].Value);

                    if (row.Cells["ActualThickness"].Value == null ||
                        !double.TryParse(row.Cells["ActualThickness"].Value.ToString(), out double t_actual))
                    {
                        MessageBox.Show($"Please enter a valid actual thickness for Course {courseNumber}.");
                        return;
                    }

                    double t_available = t_actual - ca;
                    if (t_available <= 0)
                    {
                        MessageBox.Show($"Actual thickness for Course {courseNumber} must be greater than corrosion allowance.");
                        row.Cells["MaxAllowableH"].Value = "Error";
                        continue;
                    }

                    double courseE = double.Parse(efficiencyInputs[courseNumber - 1].Text);

                    string stressKey = (courseNumber == 1 || courseNumber == 2) ?
                        "Allowable Product Stress (S) - Lower Two Courses" :
                        "Allowable Product Stress (S) - Upper Courses";

                    double S = Convert.ToDouble(materialProps[stressKey]);

                    // H = ((t_available * S * E) / (2.6 * D * G)) + 1
                    double H = ((t_available * S * courseE) / (2.6 * D * G)) + 1.0;

                    row.Cells["MaxAllowableH"].Value = H.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in calculating max allowable height: {ex.Message}");
            }
        }

        /// <summary>
        /// Calculates the Minimum Remaining Thickness (MRT) for the tank bottom and updates the result label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitializeMrtDropdown()
        {
            var mrtOptions = new List<string>
            {
                "None",
                "RPB",
                "Double Bottom"
            };
            cmbTable4_4.DataSource = mrtOptions;
        }

        private void btnCalculateMrt_Click(object sender, EventArgs e)
        {
            if (!ValidateMrtInputs()) return;
            try
            {
                double rtbc = double.Parse(txtRTbc.Text);
                double rtip = double.Parse(txtRTip.Text);
                double or = double.Parse(txtOr.Text);
                double stpr = double.Parse(txtStPr.Text);
                double upr = double.Parse(txtUPr.Text);
                string selectedMrt = cmbTable4_4.SelectedItem.ToString();

                // Calculate MRT
                double mrt = Math.Min(rtbc, rtip) - or * (stpr + upr);
                if (mrt < 0) mrt = 0; // Prevent negative MRT values

                // Determine required MRT based on Table 4.4
                double requiredMrt;
                switch (selectedMrt)
                {
                    case "RPB":
                    case "Double Bottom":
                        requiredMrt = 0.05;
                        break;
                    default: // Default case for "None"
                        requiredMrt = 0.10;
                        break;
                }

                // Apply coating life adjustment if bottom is coated
                if (chkBottomCoated.Checked && double.TryParse(txtCoatingLife.Text, out double coatingLife))
                {
                    requiredMrt = Math.Max(requiredMrt, 0.1 - (coatingLife * upr));
                }

                // Display results
                string resultText = $"Calculated MRT: {mrt:F4} in.\n";
                resultText += $"Required MRT: {requiredMrt:F4} in. (per API 653 Table 4.4)\n";

                if (mrt >= requiredMrt)
                {
                    resultText += "✅ PASS - Meets API 653 requirements";
                    lblMrtResult.ForeColor = Color.Green;
                }
                else
                {
                    resultText += "❌ FAIL - Below minimum required thickness";
                    lblMrtResult.ForeColor = Color.Red;
                }

                lblMrtResult.Text = resultText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in MRT calculation: {ex.Message}");
            }
        }

        /// <summary>
        /// Calculates the required thickness for the critical zone of the tank bottom and updates the result label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool ValidateAndParseControl(Control control, string fieldName, out double parsedValue)
        {
            parsedValue = 0;
            if (string.IsNullOrWhiteSpace(control.Text))
            {
                MessageBox.Show($"{fieldName} is a mandatory field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            if (!double.TryParse(control.Text, out parsedValue) || parsedValue < 0)
            {
                MessageBox.Show($"Please enter a valid, non-negative number for {fieldName}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                control.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateLocalizedCorrosionInputs(out double D, out double t2, out double t_min, out double L_actual)
        {
            D = 0;
            t2 = 0;
            t_min = 0;
            L_actual = 0;

            if (!ValidateAndParseControl(txtDiameterLocalized, "Tank Diameter (D)", out D)) return false;
            if (!ValidateAndParseControl(txtT2Localized, "Minimum Thickness in Area (t2, in)", out t2)) return false;
            if (!ValidateAndParseControl(txtTminLocalized, "Minimum Req. Thickness (t_min, in)", out t_min)) return false;
            if (!ValidateAndParseControl(txtLactualLocalized, "Actual Measured Length (L_actual, in)", out L_actual)) return false;

            return true;
        }

        private void btnCalculateCriticalZone_Click(object sender, EventArgs e)
        {
            if (!ValidateCriticalZoneInputs()) return;
            try
            {
                double originalBottomThickness = double.Parse(txtOriginalBottomThickness.Text);
                double tmin_shell_course1 = double.Parse(txtTminShellCourse1.Text);

                // Per API 653 4.3.3
                double calculatedThickness = 0.1 * Math.Sqrt(originalBottomThickness * tmin_shell_course1);

                // Enforce minimum thickness of 0.1"
                double finalThickness = Math.Max(calculatedThickness, 0.1);

                string resultText = $"Calculated Thickness: {calculatedThickness:F4} in.\n";
                resultText += $"Final Required Thickness (governed by min 0.1\"): {finalThickness:F4} in.\n";
                resultText += $"Ref: API 653 4.3.3";

                lblCriticalZoneResult.Text = resultText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Critical Zone calculation: {ex.Message}");
            }
        }

        /// <summary>
        /// Calculates the required thickness for the annular plate and updates the result label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool ValidateCriticalZoneInputs()
        {
            var controlsToValidate = new List<Tuple<Control, string>>
            {
                Tuple.Create<Control, string>(txtOriginalBottomThickness, "Original Bottom Thickness"),
                Tuple.Create<Control, string>(txtTminShellCourse1, "t_min 1st Shell Course")
            };

            foreach (var tuple in controlsToValidate)
            {
                if (string.IsNullOrWhiteSpace(tuple.Item1.Text))
                {
                    MessageBox.Show($"{tuple.Item2} is a mandatory field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tuple.Item1.Focus();
                    return false;
                }
                if (!double.TryParse(tuple.Item1.Text, out double value) || value < 0)
                {
                    MessageBox.Show($"Please enter a valid, non-negative number for {tuple.Item2}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tuple.Item1.Focus();
                    return false;
                }
            }
            return true;
        }

        private void InitializeAnnularPlateTab()
        {
            txtAsBuiltFirstCourse.TextChanged += UpdateAnnularPlateResult;
            txtAnnularCorrosionAllowance.TextChanged += UpdateAnnularPlateResult;
        }

        private void UpdateAnnularPlateResult(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtAsBuiltFirstCourse.Text, out double tFirstCourse) ||
                    !double.TryParse(txtAnnularCorrosionAllowance.Text, out double CA))
                {
                    lblAnnularPlateResult.Text = "Result: (invalid input)";
                    return;
                }

                double baseThickness = Math.Min(tFirstCourse, 0.25);
                double requiredThickness = baseThickness + CA;
                double finalThickness = Math.Max(requiredThickness, 0.25);

                lblAnnularPlateResult.Text = $"Result: {finalThickness:F3} in";
                lblAnnularPlateResult.ForeColor = Color.Black;
            }
            catch
            {
                lblAnnularPlateResult.Text = "Result: (error)";
                lblAnnularPlateResult.ForeColor = Color.Red;
            }
        }

        private void btnCalculateAnnularPlate_Click(object sender, EventArgs e)
        {
            if (!ValidateAnnularPlateInputs()) return;
            // The real-time preview has already updated the result label.
            // This button can be used to force a recalculation if needed,
            // or if the real-time updates were disabled for performance.
            UpdateAnnularPlateResult(sender, e);
        }

        private bool ValidateAnnularPlateInputs()
        {
            if (!double.TryParse(txtAsBuiltFirstCourse.Text, out double tFirstCourse) ||
                !double.TryParse(txtAnnularCorrosionAllowance.Text, out double CA))
            {
                MessageBox.Show("Please enter valid numbers for all fields in the Annular Plate section.");
                return false;
            }

            if (tFirstCourse < 0 || CA < 0)
            {
                MessageBox.Show("Negative values are not allowed for thickness or corrosion allowance.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tFirstCourse < 0.25)
            {
                MessageBox.Show("First course thickness is less than 0.25 in, which may violate API 653.", "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return true;
        }

        private bool ValidateMrtInputs()
        {
            var controlsToValidate = new List<Tuple<Control, string>>
            {
                Tuple.Create<Control, string>(txtRTbc, "Bottom-side thickness (RTbc)"),
                Tuple.Create<Control, string>(txtRTip, "Top-side thickness (RTip)"),
                Tuple.Create<Control, string>(txtOr, "Inspection interval (Or)"),
                Tuple.Create<Control, string>(txtStPr, "Top-side corrosion rate (StPr)"),
                Tuple.Create<Control, string>(txtUPr, "Bottom-side corrosion rate (UPr)")
            };

            foreach (var tuple in controlsToValidate)
            {
                if (string.IsNullOrWhiteSpace(tuple.Item1.Text))
                {
                    MessageBox.Show($"{tuple.Item2} is a mandatory field.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!double.TryParse(tuple.Item1.Text, out double value) || value < 0)
                {
                    MessageBox.Show($"Please enter a valid, non-negative number for {tuple.Item2}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (double.Parse(txtOr.Text) > 20)
            {
                MessageBox.Show("Inspection interval (Or) cannot exceed 20 years per API 653 6.4.2.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (chkBottomCoated.Checked)
            {
                if (!double.TryParse(txtCoatingLife.Text, out double coatingLife) || coatingLife < 0)
                {
                    MessageBox.Show("Please enter a valid, non-negative number for Coating Life.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool ValidateShellInputs()
        {
            if (!double.TryParse(txtDiameter.Text, out double D) || D <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for the tank diameter.");
                return false;
            }
            if (!double.TryParse(txtSpecificGravity.Text, out double G) || G <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for the specific gravity.");
                return false;
            }
            return true;
        }

        private bool ValidateInputs()
        {
            // This method is now simplified or can be removed if all validations are specific.
            // For now, it will validate the shell inputs as a default.
            if (tabControl1.SelectedTab == tabShellEval)
            {
                return ValidateShellInputs();
            }

            // Other tabs now have their own validation.
            return true;
        }

        private void InitializeTooltips()
        {
            // Shell Evaluation
            toolTip1.SetToolTip(txtDiameter, "Enter the nominal diameter of the tank in feet.");
            toolTip1.SetToolTip(txtYieldStrength, "Enter the specified minimum yield strength of the shell material in psi.");
            toolTip1.SetToolTip(txtTensileStrength, "Enter the specified minimum tensile strength of the shell material in psi.");
            toolTip1.SetToolTip(txtSpecificGravity, "Enter the specific gravity of the product to be stored.");
            toolTip1.SetToolTip(txtCorrosionAllowance, "Enter the corrosion allowance in inches.");
            toolTip1.SetToolTip(btnCalculate, "Calculate the minimum required shell thickness for each course.\n\n" +
                "Stress Determination Logic:\n" +
                "1. For materials in API 650 Table 4.1:\n" +
                "   - Allowable Stress = Table Value × Joint Efficiency\n" +
                "   - Lower courses use \"Lower Two Courses\" column\n" +
                "   - Upper courses use \"Upper Courses\" column\n" +
                "2. For other materials:\n" +
                "   - Allowable Stress = min(2/3×Y×E, 2/5×T×E)");
            toolTip1.SetToolTip(btnCalculateHydro, "Calculate the maximum allowable hydrostatic test height for each course.");
            toolTip1.SetToolTip(btnSolveForH, "Calculate the maximum allowable liquid height for each course based on the actual thickness.");

            // Bottom Evaluation - MRT
            toolTip1.SetToolTip(txtRTbc, "Minimum remaining thickness on the bottom side, in inches. (RTbc)");
            toolTip1.SetToolTip(txtRTip, "Minimum remaining thickness on the top (product) side, in inches. (RTip)");
            toolTip1.SetToolTip(txtOr, "Time until the next inspection, in years. (Or)");
            toolTip1.SetToolTip(txtStPr, "Corrosion rate on the top (product) side, in inches per year. (StPr)");
            toolTip1.SetToolTip(txtUPr, "Corrosion rate on the bottom side, in inches per year. (UPr)");
            toolTip1.SetToolTip(cmbTable4_4, "Select the type of leak detection or containment system under the tank bottom.");
            toolTip1.SetToolTip(chkBottomCoated, "Check if the tank bottom is coated, which may affect the required MRT.");
            toolTip1.SetToolTip(txtCoatingLife, "Enter the expected life of the coating in years.");
            toolTip1.SetToolTip(btnCalculateMrt, "Calculate the Minimum Remaining Thickness (MRT) for the tank bottom per API 653 4.4.2.");

            // Bottom Evaluation - Critical Zone
            toolTip1.SetToolTip(txtOriginalBottomThickness, "The original or nominal thickness of the bottom plate, in inches.");
            toolTip1.SetToolTip(txtTminShellCourse1, "The minimum required thickness of the first shell course, in inches.");
            toolTip1.SetToolTip(btnCalculateCriticalZone, "Calculate the required thickness for the critical zone of the tank bottom per API 653 4.3.3.");

            // Bottom Evaluation - Annular Plate
            toolTip1.SetToolTip(txtAsBuiltFirstCourse, "The as-built thickness of the first shell course, in inches.");
            toolTip1.SetToolTip(txtAnnularCorrosionAllowance, "The corrosion allowance for the annular plate, in inches (Typical: 0.063-0.125).");
            toolTip1.SetToolTip(btnCalculateAnnularPlate, "Calculate the required thickness for the annular plate per API 653 4.4.5.");

            // Localized Corrosion
            toolTip1.SetToolTip(txtDiameterLocalized, "Tank Diameter (D) in feet. This can be auto-populated from the Shell Evaluation tab.");
            toolTip1.SetToolTip(txtT2Localized, "The minimum thickness in the corroded area, in inches (t2). Ref: API 653 4.3.2.1.b.");
            toolTip1.SetToolTip(txtTminLocalized, "The minimum required thickness of the shell course, in inches (t_min). Ref: API 653 4.3.2.1.a.");
            toolTip1.SetToolTip(txtLactualLocalized, "The longest measured length of the corroded area, in inches (L_actual).");
            toolTip1.SetToolTip(lblValidationIconLocalized, "Diameter is synced from Shell Evaluation tab.");
            toolTip1.SetToolTip(btnCalculateLocalized, "Perform a localized corrosion assessment per API 653 4.3.2.1.");
        }

        /// <summary>
        /// Performs a localized corrosion assessment and updates the result label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateLocalized_Click(object sender, EventArgs e)
        {
            if (!ValidateLocalizedCorrosionInputs(out double D, out double t2, out double t_min, out double L_actual)) return;

            try
            {
                // --- Calculations ---
                double L_allowable = Math.Min(3.7 * Math.Sqrt(D * t2), 40.0);
                double t_min_60_percent = 0.6 * t_min;

                bool thickness_pass = t2 >= t_min_60_percent;
                bool length_pass = L_actual <= L_allowable;
                bool overall_pass = thickness_pass && length_pass;

                // --- Result Formatting ---
                rtbLocalizedResult.Clear();

                rtbLocalizedResult.AppendText("--- Localized Corrosion Assessment ---\n");
                rtbLocalizedResult.AppendText($"Allowable Length (L): {L_allowable:F2} in\n\n");

                // Thickness Check
                rtbLocalizedResult.AppendText($"Thickness Check (t2 >= 0.6*t_min):\n  {t2:F3} in >= {t_min_60_percent:F3} in -> ");
                rtbLocalizedResult.SelectionColor = thickness_pass ? Color.DarkGreen : Color.Red;
                rtbLocalizedResult.AppendText(thickness_pass ? "PASS\n" : "FAIL\n");
                rtbLocalizedResult.SelectionColor = rtbLocalizedResult.ForeColor;

                // Length Check
                rtbLocalizedResult.AppendText($"Length Check (L_actual <= L):\n  {L_actual:F3} in <= {L_allowable:F2} in -> ");
                rtbLocalizedResult.SelectionColor = length_pass ? Color.DarkGreen : Color.Red;
                rtbLocalizedResult.AppendText(length_pass ? "PASS\n\n" : "FAIL\n\n");
                rtbLocalizedResult.SelectionColor = rtbLocalizedResult.ForeColor;

                // Overall Result
                rtbLocalizedResult.AppendText("Overall Result: ");
                rtbLocalizedResult.SelectionFont = new Font(rtbLocalizedResult.Font, FontStyle.Bold);
                rtbLocalizedResult.SelectionColor = overall_pass ? Color.DarkGreen : Color.Red;
                rtbLocalizedResult.AppendText(overall_pass ? "PASS" : "FAIL");
                rtbLocalizedResult.SelectionFont = new Font(rtbLocalizedResult.Font, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Localized Corrosion calculation: {ex.Message}");
            }
        }

        // --- Settlement Evaluation Logic ---

        // Data structure for API 653 Table B-1: Allowable Out-of-Plane Settlement, B (inches)
        private static readonly List<double> TableB1_Thicknesses = new List<double> { 0.25, 0.375, 0.5, 0.625, 0.75, 0.875, 1.0 };
        private static readonly Dictionary<double, List<double?>> TableB1_Data = new Dictionary<double, List<double?>>
        {
            // Arc Length (ft) -> [t<=1/4", t=3/8", t=1/2", t=5/8", t=3/4", t=7/8", t=1"]
            [10] = new List<double?> { 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0 },
            [20] = new List<double?> { 1.2, 1.5, 1.8, 2.1, 2.4, 2.7, 3.0 },
            [30] = new List<double?> { 2.1, 2.7, 3.2, 3.8, 4.3, 4.9, 5.4 },
            [40] = new List<double?> { 3.8, 4.8, 5.8, 6.7, 7.7, null, null },
            [50] = new List<double?> { null, 7.5, 9.0, null, null, null, null }
        };

        /// <summary>
        /// Performs a 2D linear interpolation on API 653 Table B-1 to find the allowable out-of-plane settlement.
        /// </summary>
        /// <param name="arcLengthFt">The arc length between measurement points, in feet.</param>
        /// <param name="shellThicknessIn">The shell thickness, in inches.</param>
        /// <returns>The allowable settlement in inches, or -1 if interpolation is not possible.</returns>
        private double GetAllowableDifferentialSettlement(double arcLengthFt, double shellThicknessIn)
        {
            try
            {
                // Find bracketing thickness indices
                int t_idx1 = -1, t_idx2 = -1;
                for (int i = 0; i < TableB1_Thicknesses.Count; i++)
                {
                    if (TableB1_Thicknesses[i] >= shellThicknessIn)
                    {
                        t_idx2 = i;
                        break;
                    }
                }
                if (t_idx2 == -1) t_idx2 = TableB1_Thicknesses.Count - 1; // Thicker than table max, clamp to last column
                t_idx1 = (t_idx2 > 0) ? t_idx2 - 1 : 0;

                double t1 = TableB1_Thicknesses[t_idx1];
                double t2 = TableB1_Thicknesses[t_idx2];

                // Find bracketing arc length keys
                var arcLengthKeys = TableB1_Data.Keys.OrderBy(k => k).ToList();
                double l_key1 = -1, l_key2 = -1;
                for (int i = 0; i < arcLengthKeys.Count; i++)
                {
                    if (arcLengthKeys[i] >= arcLengthFt)
                    {
                        l_key2 = arcLengthKeys[i];
                        break;
                    }
                }
                if (l_key2 == -1) l_key2 = arcLengthKeys.Last(); // Longer than table max, clamp to last row
                l_key1 = (l_key2 > arcLengthKeys.First()) ? arcLengthKeys[arcLengthKeys.IndexOf(l_key2) - 1] : arcLengthKeys.First();

                // First, interpolate along the arc length (L) axis for the lower bounding thickness (t1).
                double? val_t1_l1 = TableB1_Data[l_key1][t_idx1];
                double? val_t1_l2 = TableB1_Data[l_key2][t_idx1];
                if (val_t1_l1 == null || val_t1_l2 == null) return -1; // Cannot interpolate if data is missing
                double B_at_t1 = LinearInterpolate(arcLengthFt, l_key1, l_key2, val_t1_l1.Value, val_t1_l2.Value);

                // Second, interpolate along the arc length (L) axis for the upper bounding thickness (t2).
                double? val_t2_l1 = TableB1_Data[l_key1][t_idx2];
                double? val_t2_l2 = TableB1_Data[l_key2][t_idx2];
                if (val_t2_l1 == null || val_t2_l2 == null) return -1; // Cannot interpolate if data is missing
                double B_at_t2 = LinearInterpolate(arcLengthFt, l_key1, l_key2, val_t2_l1.Value, val_t2_l2.Value);

                // Finally, interpolate along the thickness (t) axis using the results from the previous interpolations.
                double final_B = LinearInterpolate(shellThicknessIn, t1, t2, B_at_t1, B_at_t2);

                return final_B;
            }
            catch
            {
                // Return -1 to indicate an error during lookup/interpolation
                return -1;
            }
        }

        private double LinearInterpolate(double x, double x1, double x2, double y1, double y2)
        {
            if (x1 == x2) return y1; // Avoid division by zero, return the value at the point
            return y1 + (x - x1) * (y2 - y1) / (x2 - x1);
        }

        private void InitializeSettlementTab()
        {
            // Setup DataGridView columns
            dgvSettlementPoints.Columns.Clear();
            dgvSettlementPoints.Columns.Add("PointID", "Point ID");
            dgvSettlementPoints.Columns.Add("Elevation", "Elevation (in)");
            dgvSettlementPoints.Columns.Add("RadialPosition", "Radial Position (°)");

            // Set column properties
            dgvSettlementPoints.Columns["PointID"].ReadOnly = true;
            dgvSettlementPoints.Columns["RadialPosition"].ReadOnly = true;
            dgvSettlementPoints.Columns["Elevation"].ValueType = typeof(double);
            dgvSettlementPoints.AllowUserToAddRows = false; // Prevent blank row at the end

            // Populate with 8 default points
            for (int i = 0; i < 8; i++)
            {
                dgvSettlementPoints.Rows.Add(i + 1, null, i * 45);
            }

            // Add event handlers for the new buttons
            btnAddSettlementPoint.Click += btnAddSettlementPoint_Click;
            btnClearSettlementPoints.Click += btnClearSettlementPoints_Click;

            // Add logic for data linking
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            txtSettlementDiameter.TextChanged += txtSettlementDiameter_TextChanged;
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabSettlementEval)
            {
                LinkDataToSettlementTab();
            }
            else if (tabControl1.SelectedTab == tabLocalizedCorrosion)
            {
                if (double.TryParse(txtDiameter.Text, out double diameter))
                {
                    SyncDiameterFromShell(diameter);
                }
            }
        }

        public void SyncDiameterFromShell(double diameter)
        {
            if (string.IsNullOrEmpty(txtDiameterLocalized.Text))
            {
                txtDiameterLocalized.Text = diameter.ToString("0.00");
                txtDiameterLocalized.BackColor = Color.FromArgb(240, 240, 255);
            }
        }

        private void LinkDataToSettlementTab()
        {
            // Pre-fill from Shell Evaluation tab, but only if the settlement fields are empty
            if (string.IsNullOrWhiteSpace(txtSettlementDiameter.Text))
                txtSettlementDiameter.Text = txtDiameter.Text;

            double totalHeight = 0;
            bool allHeightsValid = true;
            foreach (var heightInput in heightInputs)
            {
                if (double.TryParse(heightInput.Text, out double h))
                {
                    totalHeight += h;
                }
                else
                {
                    allHeightsValid = false;
                    break;
                }
            }
            if (allHeightsValid && heightInputs.Count > 0 && string.IsNullOrWhiteSpace(txtSettlementShellHeight.Text))
            {
                txtSettlementShellHeight.Text = totalHeight.ToString("0.00");
            }

            if (resultGrid.Rows.Count > 0 && resultGrid.Rows[0].Cells["MinThickness"].Value != null && string.IsNullOrWhiteSpace(txtSettlementTshell.Text))
            {
                txtSettlementTshell.Text = resultGrid.Rows[0].Cells["MinThickness"].Value.ToString();
            }
        }


        private void UpdateRadialPositions()
        {
            int pointCount = dgvSettlementPoints.Rows.Count;
            if (pointCount == 0) return;

            double angleIncrement = 360.0 / pointCount;

            for (int i = 0; i < pointCount; i++)
            {
                dgvSettlementPoints.Rows[i].Cells["PointID"].Value = i + 1;
                dgvSettlementPoints.Rows[i].Cells["RadialPosition"].Value = Math.Round(i * angleIncrement, 2);
            }
        }

        private void btnAddSettlementPoint_Click(object sender, EventArgs e)
        {
            dgvSettlementPoints.Rows.Add(null, null, null); // Add a blank row
            UpdateRadialPositions(); // Renumber IDs and recalculate positions
            UpdateRecommendedPointsLabel();
        }

        private void btnClearSettlementPoints_Click(object sender, EventArgs e)
        {
            dgvSettlementPoints.Rows.Clear();
            for (int i = 0; i < 8; i++)
            {
                dgvSettlementPoints.Rows.Add(null, null, null); // Add 8 blank rows
            }
            UpdateRadialPositions(); // Set the default 8 points with correct IDs and positions
            UpdateRecommendedPointsLabel();
        }

        private void txtSettlementDiameter_TextChanged(object sender, EventArgs e)
        {
            UpdateRecommendedPointsLabel();
        }

        private void UpdateRecommendedPointsLabel()
        {
            if (double.TryParse(txtSettlementDiameter.Text, out double D))
            {
                int recommendedPoints = GetRecommendedSurveyPoints(D);
                lblRecommendedPoints.Text = $"Recommended: {recommendedPoints} points (for {D} ft tank)";

                if (dgvSettlementPoints.Rows.Count >= recommendedPoints)
                {
                    lblRecommendedPoints.ForeColor = Color.Green;
                }
                else
                {
                    lblRecommendedPoints.ForeColor = Color.Red;
                }
            }
            else
            {
                lblRecommendedPoints.Text = "Recommended: (enter valid diameter)";
                lblRecommendedPoints.ForeColor = Color.Gray;
            }
        }

        private void btnCalculateSettlement_Click(object sender, EventArgs e)
        {
            if (!ValidateSettlementInputs()) return;

            try
            {
                // 1. Parse inputs
                double D = double.Parse(txtSettlementDiameter.Text);
                double t_shell = double.Parse(txtSettlementTshell.Text);
                double t_b = double.Parse(txtBottomThickness.Text);
                double refElevation = double.Parse(txtReferenceElevation.Text);
                double centerElevation = double.Parse(txtCenterElevation.Text);

                List<double> elevations = new List<double>();
                foreach (DataGridViewRow row in dgvSettlementPoints.Rows)
                {
                    if (row.Cells["Elevation"].Value != null && double.TryParse(row.Cells["Elevation"].Value.ToString(), out double elev))
                    {
                        elevations.Add(elev);
                    }
                }

                // 2. Calculate differential settlement and tilt
                double S_d = CalculateMaxDifferential(elevations);
                double arcLength = (Math.PI * D) / elevations.Count;
                double allowable_S_d = GetAllowableDifferentialSettlement(arcLength, t_shell);
                if (allowable_S_d == -1)
                {
                    MessageBox.Show("Could not determine allowable differential settlement. The input values may be outside the range of API 653 Table B-1.", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Corrected Tilt Calculation using Atan2 for robustness
                double theta = Math.Atan2(elevations.Max() - elevations.Min(), D * 12);

                // 3. Check bottom settlement
                // Corrected Edge Settlement Calculation: max(elevations) - reference_elevation
                double edgeSettlement = elevations.Max() - refElevation;
                // Per API 653 B.3.2.1, Allowable Edge Settlement B = 0.37 * D (D in ft -> B in inches)
                double allowableEdgeSettlement = 0.37 * D;

                double centerSettlement = refElevation - centerElevation;
                // Corrected Center Settlement with practical limit of 12 inches
                // Per API 653 B.3.3.2, S = (0.26 * R^2) / t_b. (R in ft, t_b in inches -> S in inches)
                double R = D / 2.0; // Radius in feet
                double theoretical_allowable_center = (0.26 * R * R) / t_b;
                double allowableCenterSettlement = Math.Min(theoretical_allowable_center, 12.0);

                UpdateSettlementUI(S_d, allowable_S_d, theta, edgeSettlement, allowableEdgeSettlement, centerSettlement, allowableCenterSettlement);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during settlement calculation: {ex.Message}", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateSettlementInputs()
        {
            if (!double.TryParse(txtSettlementDiameter.Text, out _) ||
                !double.TryParse(txtSettlementShellHeight.Text, out _) ||
                !double.TryParse(txtBottomThickness.Text, out _) ||
                !double.TryParse(txtSettlementTshell.Text, out _) ||
                !double.TryParse(txtReferenceElevation.Text, out _) ||
                !double.TryParse(txtCenterElevation.Text, out _))
            {
                MessageBox.Show("Please ensure all input fields contain valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Add thickness validation
            double t_shell_val = double.Parse(txtSettlementTshell.Text);
            double t_b_val = double.Parse(txtBottomThickness.Text);

            if (t_shell_val > 24 || t_b_val > 24)
            {
                MessageBox.Show("Thickness values greater than 24 inches are unusual. Please verify that your inputs are in inches and not another unit.", "Unit Verification Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dgvSettlementPoints.Rows.Count < 8)
            {
                MessageBox.Show("Please provide at least 8 settlement survey points.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (DataGridViewRow row in dgvSettlementPoints.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["Elevation"].Value == null || !double.TryParse(row.Cells["Elevation"].Value.ToString(), out _))
                {
                    MessageBox.Show($"Please enter a valid numeric elevation for Point ID {row.Cells["PointID"].Value}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private double CalculateMaxDifferential(List<double> elevations)
        {
            if (elevations.Count < 2) return 0;
            return elevations.Max() - elevations.Min();
        }

        private void UpdateSettlementUI(double S_d, double allowable_S_d, double theta, double edgeSettlement, double allowableEdgeSettlement, double centerSettlement, double allowableCenterSettlement)
        {
            lblMaxDifferentialSettlement.Text = $"Max Differential Settlement: {S_d:F2} in";
            lblAllowableDifferential.Text = $"Allowable Differential Settlement: {allowable_S_d:F2} in";
            lblTiltAngle.Text = $"Tilt Angle: {theta:F4} rad";
            lblEdgeSettlement.Text = $"Edge Settlement: {edgeSettlement:F2} in";
            lblAllowableEdge.Text = $"Allowable Edge Settlement: {allowableEdgeSettlement:F2} in";
            lblCenterSettlement.Text = $"Center Settlement: {centerSettlement:F2} in";
            lblAllowableCenter.Text = $"Allowable Center Settlement: {allowableCenterSettlement:F2} in";

            rtbSettlementSummary.Clear();
            var summary = new System.Text.StringBuilder();
            summary.AppendLine("SETTLEMENT EVALUATION RESULTS:");

            bool isCompliant = true;

            if (S_d <= allowable_S_d)
                summary.AppendLine($"- Differential Settlement: {S_d:F2} in (Allowable: {allowable_S_d:F2} in) ✅ PASS");
            else
            {
                summary.AppendLine($"- Differential Settlement: {S_d:F2} in (Allowable: {allowable_S_d:F2} in) ❌ FAIL");
                isCompliant = false;
            }

            // Per common engineering practice, a tank tilt ratio of 1/120 is a conservative practical limit.
            double allowable_theta = 1.0 / 120.0;
            if (theta <= allowable_theta)
                summary.AppendLine($"- Tilt Angle: {theta:F4} rad (Allowable: {allowable_theta:F4} rad) ✅ PASS");
            else
            {
                summary.AppendLine($"- Tilt Angle: {theta:F4} rad (Allowable: {allowable_theta:F4} rad) ❌ FAIL");
                isCompliant = false;
            }

            if (edgeSettlement <= allowableEdgeSettlement)
                summary.AppendLine($"- Edge Settlement: {edgeSettlement:F2} in (Allowable: {allowableEdgeSettlement:F2} in) ✅ PASS");
            else
            {
                summary.AppendLine($"- Edge Settlement: {edgeSettlement:F2} in (Allowable: {allowableEdgeSettlement:F2} in) ❌ FAIL");
                isCompliant = false;
            }

            if (Math.Abs(centerSettlement) <= allowableCenterSettlement)
                summary.AppendLine($"- Center Settlement: {centerSettlement:F2} in (Allowable: {allowableCenterSettlement:F2} in) ✅ PASS");
            else
            {
                summary.AppendLine($"- Center Settlement: {centerSettlement:F2} in (Allowable: {allowableCenterSettlement:F2} in) ❌ FAIL");
                isCompliant = false;
            }

            // Add a note about the nature of the center settlement allowable value, as it can be very large.
            // Heuristic: Show note if the allowable value is greater than 10% of the tank's diameter in inches.
            double D_in = double.Parse(txtSettlementDiameter.Text) * 12.0;
            if (allowableCenterSettlement > (D_in / 10.0))
            {
                summary.AppendLine("  NOTE: The allowable center settlement is a theoretical value from the API 653 formula.");
                summary.AppendLine("  Practical limits based on engineering judgment may also apply.");
            }

            summary.AppendLine();
            if (isCompliant)
                summary.AppendLine("CONCLUSION: Settlement is within API 653 limits.");
            else
                summary.AppendLine("CONCLUSION: Settlement EXCEEDS API 653 limits. Further investigation is required.");

            rtbSettlementSummary.Text = summary.ToString();
        }

        /// <summary>
        /// Recommends minimum survey points per API 653/650 standards.
        /// </summary>
        /// <param name="diameterFt">Tank diameter in feet (must be > 0).</param>
        /// <returns>Recommended number of survey points.</returns>
        /// <remarks>
        /// Follows API 653 (min 8 points) and API 650 Annex B (closer spacing for large tanks).
        /// For diameters >120 ft, recommends 1 point per 10 ft to detect localized shell distortion.
        /// </remarks>
        private void chkBottomCoated_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = chkBottomCoated.Checked;
            lblCoatingLife.Visible = isChecked;
            txtCoatingLife.Visible = isChecked;
        }

        public int GetRecommendedSurveyPoints(double diameterFt)
        {
            if (diameterFt <= 0)
            {
                // Optional: Log a warning here
                return 8; // Fallback for invalid input
            }

            if (diameterFt <= 50)
            {
                return 8;
            }
            else if (diameterFt <= 120)
            {
                return 12;
            }
            else
            {
                int calculatedPoints = (int)Math.Ceiling(diameterFt / 10.0);
                return Math.Max(16, calculatedPoints);
            }
        }

        private void TxtCourseHeight_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null || string.IsNullOrWhiteSpace(txtBox.Text)) return;

            if (!double.TryParse(txtBox.Text, out double height))
            {
                MessageBox.Show("Please enter a valid number for the course height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (height < 0)
            {
                MessageBox.Show("Course height cannot be negative.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (height > 0 && height < 6.0)
            {
                MessageBox.Show("According to API 650, shell plates typically have a minimum nominal width of 1800 mm (72 inches or 6 feet) unless otherwise agreed upon by the purchaser.", "API 650 Guidance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtEfficiency_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (txtBox == null || string.IsNullOrWhiteSpace(txtBox.Text)) return;

            if (!double.TryParse(txtBox.Text, out double efficiency))
            {
                MessageBox.Show("Please enter a valid number for the joint efficiency.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }

            if (efficiency < 0.0 || efficiency > 1.0)
            {
                MessageBox.Show("Joint efficiency must be between 0.0 and 1.0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
