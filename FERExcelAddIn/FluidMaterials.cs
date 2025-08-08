using System;
using System.Collections.Generic;

public static class MaterialDatabase
{
    public static readonly Dictionary<string, MaterialProperties> Materials =
        new Dictionary<string, MaterialProperties>(StringComparer.OrdinalIgnoreCase)
    {
        // ================= COMMON GASES =================
        {
            "Air",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 28.97,
                SpecificHeatRatio = 1.40,
                Compressibility = 0.99,
                Viscosity = 0.018,
                SpecificGravity = 1.00,
                DefaultTemperature = 25,
                IsSpecialCase = true
            }
        },
        {
            "Nitrogen (N₂)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 28.01,
                SpecificHeatRatio = 1.40,
                Compressibility = 0.99,
                Viscosity = 0.017,
                SpecificGravity = 0.97,
                DefaultTemperature = 25
            }
        },
        {
            "Oxygen (O₂)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 32.00,
                SpecificHeatRatio = 1.40,
                Compressibility = 0.99,
                Viscosity = 0.020,
                SpecificGravity = 1.11,
                DefaultTemperature = 25
            }
        },
        {
            "Carbon Dioxide (CO₂)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 44.01,
                SpecificHeatRatio = 1.28,
                Compressibility = 0.94,
                Viscosity = 0.015,
                SpecificGravity = 1.52,
                DefaultTemperature = 25
            }
        },
        {
            "Hydrogen (H₂)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 2.02,
                SpecificHeatRatio = 1.41,
                Compressibility = 1.01,
                Viscosity = 0.009,
                SpecificGravity = 0.07,
                DefaultTemperature = 25
            }
        },

        // ================= HYDROCARBON GASES =================
        {
            "Methane (CH₄)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 16.04,
                SpecificHeatRatio = 1.31,
                Compressibility = 0.95,
                Viscosity = 0.011,
                SpecificGravity = 0.55,
                DefaultTemperature = 25
            }
        },
        {
            "Ethane (C₂H₆)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 30.07,
                SpecificHeatRatio = 1.19,
                Compressibility = 0.95,
                Viscosity = 0.009,
                SpecificGravity = 1.04,
                DefaultTemperature = 25
            }
        },
        {
            "Propane (C₃H₈)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 44.1,
                SpecificHeatRatio = 1.13,
                Compressibility = 0.9,
                Viscosity = 0.008,
                SpecificGravity = 1.52,
                DefaultTemperature = 25
            }
        },
        {
            "Butane (C₄H₁₀)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 58.12,
                SpecificHeatRatio = 1.09,
                Compressibility = 0.85,
                Viscosity = 0.007,
                SpecificGravity = 2.01,
                DefaultTemperature = 25
            }
        },
        {
            "Ethylene (C₂H₄)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 28.05,
                SpecificHeatRatio = 1.24,
                Compressibility = 0.98,
                Viscosity = 0.01,
                SpecificGravity = 0.97,
                DefaultTemperature = 25
            }
        },
        {
            "Propylene (C₃H₆)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 42.08,
                SpecificHeatRatio = 1.15,
                Compressibility = 0.92,
                Viscosity = 0.008,
                SpecificGravity = 1.45,
                DefaultTemperature = 25
            }
        },

        // ================= REFINERY STREAMS =================
        {
            "Natural Gas (SG=0.6)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 17.4,
                SpecificHeatRatio = 1.27,
                Compressibility = 0.98,
                Viscosity = 0.012,
                SpecificGravity = 0.6,
                DefaultTemperature = 25
            }
        },
        {
            "Fuel Gas (Refinery)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 18.0,
                SpecificHeatRatio = 1.28,
                Compressibility = 0.98,
                Viscosity = 0.012,
                SpecificGravity = 0.62,
                DefaultTemperature = 25
            }
        },
        {
            "Naphtha (Light)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 100.0,
                SpecificGravity = 0.67,
                Viscosity = 0.5,
                VaporPressure = 8.0,
                BoilingPoint = 100,
                DefaultTemperature = 25,
                Density = 670,
                SpecificHeat = 2.0,
                ThermalExpansionCoefficient = 0.0014
            }
        },
        {
            "Naphtha (Heavy)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 150.0,
                SpecificGravity = 0.78,
                Viscosity = 0.9,
                VaporPressure = 2.0,
                BoilingPoint = 200,
                DefaultTemperature = 25,
                Density = 780,
                SpecificHeat = 2.0,
                ThermalExpansionCoefficient = 0.001
            }
        },
        {
            "Gasoline (Reformulated)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 110.0,
                SpecificGravity = 0.72,
                Viscosity = 0.6,
                VaporPressure = 9.0,
                BoilingPoint = 200,
                DefaultTemperature = 25,
                Density = 720,
                SpecificHeat = 2.1,
                ThermalExpansionCoefficient = 0.0011
            }
        },
        {
            "Diesel (Ultra Low Sulfur)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 200.0,
                SpecificGravity = 0.84,
                Viscosity = 2.5,
                VaporPressure = 0.1,
                BoilingPoint = 340,
                DefaultTemperature = 25,
                Density = 840,
                SpecificHeat = 1.8,
                ThermalExpansionCoefficient = 0.0008
            }
        },
        {
            "Jet Fuel (Jet A-1)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 170.0,
                SpecificGravity = 0.81,
                Viscosity = 1.8,
                VaporPressure = 0.5,
                BoilingPoint = 250,
                DefaultTemperature = 25,
                Density = 810,
                SpecificHeat = 1.9,
                ThermalExpansionCoefficient = 0.0009
            }
        },
        {
            "Crude Oil (Medium)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 250.0,
                SpecificGravity = 0.87,
                Viscosity = 15.0,
                VaporPressure = 2.0,
                BoilingPoint = 300,
                DefaultTemperature = 25,
                Density = 870,
                SpecificHeat = 2.0,
                ThermalExpansionCoefficient = 0.0007
            }
        },

        // ================= CHEMICALS & SOLVENTS =================
        {
            "Methanol (CH₃OH)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 32.04,
                SpecificGravity = 0.79,
                Viscosity = 0.59,
                VaporPressure = 16.9,
                BoilingPoint = 64.7,
                DefaultTemperature = 25,
                Density = 792,
                SpecificHeat = 2.5,
                ThermalExpansionCoefficient = 0.0012
            }
        },
        {
            "Ethanol (C₂H₅OH)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 46.07,
                SpecificGravity = 0.79,
                Viscosity = 1.2,
                VaporPressure = 7.9,
                BoilingPoint = 78.4,
                DefaultTemperature = 25,
                Density = 789,
                SpecificHeat = 2.4,
                ThermalExpansionCoefficient = 0.0011
            }
        },
        {
            "Isopropanol (C₃H₈O)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 60.10,
                SpecificGravity = 0.78,
                Viscosity = 2.4,
                VaporPressure = 4.4,
                BoilingPoint = 82.6,
                DefaultTemperature = 25,
                Density = 786,
                SpecificHeat = 2.6,
                ThermalExpansionCoefficient = 0.001
            }
        },
        {
            "Ethylene Glycol (C₂H₆O₂)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 62.07,
                SpecificGravity = 1.11,
                Viscosity = 16.1,
                VaporPressure = 0.06,
                BoilingPoint = 197.3,
                DefaultTemperature = 25,
                Density = 1110,
                SpecificHeat = 2.4,
                ThermalExpansionCoefficient = 0.0006
            }
        },
        {
            "Glycerin (C₃H₈O₃)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 92.09,
                SpecificGravity = 1.26,
                Viscosity = 1412.0,
                VaporPressure = 0.002,
                BoilingPoint = 290.0,
                DefaultTemperature = 25,
                Density = 1260,
                SpecificHeat = 2.4,
                ThermalExpansionCoefficient = 0.0005
            }
        },

        // ================= AROMATICS =================
        {
            "Benzene (C₆H₆)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 78.11,
                SpecificGravity = 0.88,
                Viscosity = 0.65,
                VaporPressure = 12.7,
                BoilingPoint = 80.1,
                DefaultTemperature = 25,
                Density = 876,
                SpecificHeat = 1.7,
                ThermalExpansionCoefficient = 0.0012
            }
        },
        {
            "Toluene (C₇H₈)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 92.14,
                SpecificGravity = 0.87,
                Viscosity = 0.59,
                VaporPressure = 3.8,
                BoilingPoint = 110.6,
                DefaultTemperature = 25,
                Density = 867,
                SpecificHeat = 1.7,
                ThermalExpansionCoefficient = 0.0011
            }
        },
        {
            "Xylene (C₈H₁₀)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 106.16,
                SpecificGravity = 0.86,
                Viscosity = 0.62,
                VaporPressure = 1.0,
                BoilingPoint = 140,
                DefaultTemperature = 25,
                Density = 864,
                SpecificHeat = 1.7,
                ThermalExpansionCoefficient = 0.001
            }
        },
        {
            "Ethylbenzene (C₈H₁₀)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 106.16,
                SpecificGravity = 0.87,
                Viscosity = 0.67,
                VaporPressure = 9.5,
                BoilingPoint = 136.2,
                DefaultTemperature = 25,
                Density = 867,
                SpecificHeat = 1.7,
                ThermalExpansionCoefficient = 0.001
            }
        },
        {
            "Cumene (C₉H₁₂)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 120.19,
                SpecificGravity = 0.86,
                Viscosity = 0.79,
                VaporPressure = 4.5,
                BoilingPoint = 152.4,
                DefaultTemperature = 25,
                Density = 862,
                SpecificHeat = 1.7,
                ThermalExpansionCoefficient = 0.0009
            }
        },
        {
            "Styrene (C₈H₈)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 104.15,
                SpecificGravity = 0.91,
                Viscosity = 0.76,
                VaporPressure = 5.0,
                BoilingPoint = 145.2,
                DefaultTemperature = 25,
                Density = 909,
                SpecificHeat = 1.7,
                ThermalExpansionCoefficient = 0.001
            }
        },

        // ================= ACIDS & CAUSTICS =================
        {
            "Acetic Acid (CH₃COOH)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 60.05,
                SpecificGravity = 1.05,
                Viscosity = 1.22,
                VaporPressure = 15.7,
                BoilingPoint = 118.1,
                DefaultTemperature = 25,
                Density = 1049,
                SpecificHeat = 2.0,
                ThermalExpansionCoefficient = 0.0011
            }
        },
        {
            "Sulfuric Acid (H₂SO₄) 98%",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 98.08,
                SpecificGravity = 1.84,
                Viscosity = 25.4,
                VaporPressure = 0.001,
                BoilingPoint = 337,
                DefaultTemperature = 25,
                Density = 1840,
                SpecificHeat = 1.4,
                ThermalExpansionCoefficient = 0.0006
            }
        },
        {
            "Hydrochloric Acid (HCl) 37%",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 36.46,
                SpecificGravity = 1.19,
                Viscosity = 2.0,
                VaporPressure = 25.0,
                BoilingPoint = 110,
                DefaultTemperature = 25,
                Density = 1180,
                SpecificHeat = 2.7,
                ThermalExpansionCoefficient = 0.0005
            }
        },
        {
            "Caustic Soda (NaOH 50%)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 40.00,
                SpecificGravity = 1.53,
                Viscosity = 70.0,
                VaporPressure = 0.0,
                BoilingPoint = 145,
                DefaultTemperature = 25,
                Density = 1530,
                SpecificHeat = 3.2,
                ThermalExpansionCoefficient = 0.0007
            }
        },
        {
            "Potassium Hydroxide (KOH 45%)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 56.11,
                SpecificGravity = 1.45,
                Viscosity = 120.0,
                VaporPressure = 0.0,
                BoilingPoint = 1320,
                DefaultTemperature = 25,
                Density = 1450,
                SpecificHeat = 3.0,
                ThermalExpansionCoefficient = 0.0007
            }
        },

        // ================= AMINE SYSTEMS =================
        {
            "MDEA Solution (50%)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 105.14,
                SpecificGravity = 1.03,
                Viscosity = 3.5,
                VaporPressure = 0.2,
                BoilingPoint = 110,
                DefaultTemperature = 40,
                Density = 1030,
                SpecificHeat = 3.5,
                ThermalExpansionCoefficient = 0.0008
            }
        },
        {
            "DEA Solution (30%)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 105.14,
                SpecificGravity = 1.02,
                Viscosity = 2.8,
                VaporPressure = 0.3,
                BoilingPoint = 105,
                DefaultTemperature = 40,
                Density = 1020,
                SpecificHeat = 3.6,
                ThermalExpansionCoefficient = 0.0008
            }
        },
        {
            "MEA Solution (20%)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 61.08,
                SpecificGravity = 1.01,
                Viscosity = 1.9,
                VaporPressure = 0.5,
                BoilingPoint = 102,
                DefaultTemperature = 40,
                Density = 1010,
                SpecificHeat = 3.8,
                ThermalExpansionCoefficient = 0.0008
            }
        },

        // ================= TWO-PHASE SYSTEMS =================
        {
            "LPG (Propane/Butane Mix)",
            new MaterialProperties {
                Type = Phase.TwoPhase,
                MolecularWeight = 50.0,
                SpecificHeatRatio = 1.11,
                SpecificGravityLiquid = 0.54,
                SpecificGravityVapor = 1.75,
                Viscosity = 0.008,
                BubblePoint = -20,
                DefaultTemperature = 25
            }
        },
        {
            "Ammonia (Saturated)",
            new MaterialProperties {
                Type = Phase.TwoPhase,
                MolecularWeight = 17.03,
                SpecificHeatRatio = 1.33,
                SpecificGravityLiquid = 0.68,
                SpecificGravityVapor = 0.59,
                Viscosity = 0.010,
                BubblePoint = -33,
                DefaultTemperature = 25
            }
        },
        {
            "CO₂ (Saturated)",
            new MaterialProperties {
                Type = Phase.TwoPhase,
                MolecularWeight = 44.01,
                SpecificHeatRatio = 1.28,
                Compressibility = 0.94,
                Viscosity = 0.015,
                SpecificGravityLiquid = 0.82,
                SpecificGravityVapor = 1.52,
                BubblePoint = -78.5,
                DefaultTemperature = -20
            }
        },
        {
            "Ethylene Oxide (C₂H₄O)",
            new MaterialProperties {
                Type = Phase.TwoPhase,
                MolecularWeight = 44.05,
                SpecificHeatRatio = 1.17,
                SpecificGravityLiquid = 0.90,
                SpecificGravityVapor = 1.52,
                Viscosity = 0.015,
                BubblePoint = 10.7,
                DefaultTemperature = 25
            }
        },

        // ================= STEAM SYSTEMS =================
        {
            "Low Pressure Steam",
            new MaterialProperties {
                Type = Phase.Steam,
                MolecularWeight = 18.02,
                SpecificHeatRatio = 1.33,
                Compressibility = 0.99,
                Viscosity = 0.013,
                DefaultTemperature = 120
            }
        },
        {
            "Medium Pressure Steam",
            new MaterialProperties {
                Type = Phase.Steam,
                MolecularWeight = 18.02,
                SpecificHeatRatio = 1.3,
                Compressibility = 0.97,
                Viscosity = 0.018,
                DefaultTemperature = 180
            }
        },
        {
            "High Pressure Steam",
            new MaterialProperties {
                Type = Phase.Steam,
                MolecularWeight = 18.02,
                SpecificHeatRatio = 1.28,
                Compressibility = 0.95,
                Viscosity = 0.025,
                DefaultTemperature = 250
            }
        },

        // ================= SPECIALTY MATERIALS =================
        {
            "Sulfur (Molten)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 256.48,
                SpecificGravity = 1.80,
                Viscosity = 90.0,
                VaporPressure = 0.0001,
                BoilingPoint = 444.6,
                DefaultTemperature = 140,
                Density = 1800,
                SpecificHeat = 0.7,
                ThermalExpansionCoefficient = 0.0002
            }
        },
        {
            "Butadiene (C₄H₆)",
            new MaterialProperties {
                Type = Phase.Gas,
                MolecularWeight = 54.09,
                SpecificHeatRatio = 1.12,
                Compressibility = 0.95,
                Viscosity = 0.007,
                SpecificGravity = 1.87,
                BoilingPoint = -4.4,
                DefaultTemperature = 25
            }
        },
        {
            "Methyl Acrylate (C₄H₆O₂)",
            new MaterialProperties {
                Type = Phase.Liquid,
                MolecularWeight = 86.09,
                SpecificGravity = 0.95,
                Viscosity = 0.5,
                VaporPressure = 65.0,
                BoilingPoint = 80.5,
                DefaultTemperature = 25,
                Density = 950,
                SpecificHeat = 2.0,
                ThermalExpansionCoefficient = 0.0012
            }
        }
    };

    public class MaterialProperties
    {
        public Phase Type { get; set; }
        public double MolecularWeight { get; set; }  // g/mol

        // Gas properties
        public double SpecificHeatRatio { get; set; } = 1.0;
        public double Compressibility { get; set; } = 1.0;
        public double SpecificGravity { get; set; } = 1.0;

        // Liquid properties
        public double VaporPressure { get; set; }    // psia
        public double BoilingPoint { get; set; }     // °C
        public double SpecificGravityLiquid { get; set; } = 1.0;
        public double Density { get; set; } // kg/m³
        public double SpecificHeat { get; set; } // kJ/kg·K
        public double ThermalExpansionCoefficient { get; set; } // 1/°C

        // Two-phase properties
        public double SpecificGravityVapor { get; set; }
        public double BubblePoint { get; set; }      // °C

        // Common
        public double Viscosity { get; set; }       // cP
        public int DefaultTemperature { get; set; } // °C
        public bool IsSpecialCase { get; set; } = false;
    }
}

public enum Phase { Gas, Liquid, TwoPhase, Steam }
