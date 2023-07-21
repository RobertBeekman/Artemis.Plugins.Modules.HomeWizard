using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Artemis.Plugins.Modules.HomeWizard.Responses;

public class P1DataResponse
{
    [JsonPropertyName("active_tariff")]
    public double ActiveTariff { get; set; }

    [JsonPropertyName("total_power_import_kwh")]
    public double TotalPowerImportKwh { get; set; }

    [JsonPropertyName("total_power_import_t1_kwh")]
    public double TotalPowerImportT1Kwh { get; set; }

    [JsonPropertyName("total_power_import_t2_kwh")]
    public double TotalPowerImportT2Kwh { get; set; }

    [JsonPropertyName("total_power_export_kwh")]
    public double TotalPowerExportKwh { get; set; }

    [JsonPropertyName("total_power_export_t1_kwh")]
    public double TotalPowerExportT1Kwh { get; set; }

    [JsonPropertyName("total_power_export_t2_kwh")]
    public double TotalPowerExportT2Kwh { get; set; }

    [JsonPropertyName("active_power_w")]
    public double ActivePowerW { get; set; }

    [JsonPropertyName("active_power_l1_w")]
    public double ActivePowerL1W { get; set; }

    [JsonPropertyName("active_current_l1_a")]
    public double ActiveCurrentL1A { get; set; }

    [JsonPropertyName("voltage_sag_l1_count")]
    public double VoltageSagL1Count { get; set; }

    [JsonPropertyName("voltage_swell_l1_count")]
    public double VoltageSwellL1Count { get; set; }

    [JsonPropertyName("any_power_fail_count")]
    public double AnyPowerFailCount { get; set; }

    [JsonPropertyName("double_power_fail_count")]
    public double doublePowerFailCount { get; set; }

    [JsonPropertyName("total_gas_m3")]
    public double TotalGasM3 { get; set; }

    [JsonPropertyName("gas_timestamp")]
    public double GasTimestamp { get; set; }
}