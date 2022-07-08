using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurHub.Data
{
  
        [Serializable]
        public enum Company
        {
            Comelit = 0,
            Deatronic = 1,
            Cred_Comelit = 2
        }

        [Serializable]
        public enum TipoCentrale
        {
            Sconosciuta = 0,
            FullRadio32 = 1,
            FullRadio64 = 2
        }

        [Serializable]
        public enum StatoPeriferica
        {
            NotUsedAuxZone = 16,
            Attiva = 6,
            Isolata = 2,
            NonDisponibile = 0
        }

        [Serializable]
        public enum TipoUnita
        {
            UnitaCentrale = 0,
            //Espansione4I1O = 2,
            EspansioneUscitaRele = 3,
            Espansione8IO = 4,
            ConcentratoreRadio = 16,
            Alimentatori = 32,
            IsolatoreDaBus = 33,
            PalIp = 34,
            Bridge = 35,
            TastieraLed = 48,
            SafeTouch = 49,
            DispositivoTouch = 50, //Planux
            LettoreRfid = 51,
            Minitouch = 53,
            IconaManagerVip = 56,
            EspansioneEthernet = 64,
            ModuloGsm = 69,
            RF_MODULE = 0x10,
            RADIO_EXT = 0x13,
            ZONE = 0x4A,
            AGENT_RADIO_CMD = 0x4D,
            OUTPUT = 0x51
        }

        [Serializable]
        public enum TipoBilanciamento
        {
            NO = 0,
            NC = 1,
            Singolo = 2,
            Doppio = 3,
            Triplo = 4,
            Double = 5,
            DoubleConEOL = 6,
            TriploConMascheramento = 7
        }

        [Serializable]
        public enum TipoEvento
        {
            Nessuno = 0,
            Sistema = 1,
            Aree = 2,
            ZonaCablata = 3,
            App = 4,
            Tastiera = 5,
            LettoreRfid = 6,
            Safetouch = 7,
            DispositiviTouch = 8,
            ControlloRemoto = 9,
            Utente = 10,
            RadioComando = 11,
            Gruppi = 12,
            Timer = 13,
            Uscita = 14,
            Azione = 15,
            CambioCodice = 16,
            RipristinoDb = 17,
            Bridge = 18
        }



        [Serializable]
        public enum TipoCampo
        {
            Sconosciuto = 0,
            Numero = 1,
            Stringa = 2,
            Bit = 3,
            Hex = 4,
            OreMinutiSecondi = 5,
            Minuti = 6,
            Step = 7,
            ByteArray = 8,
            IpAddress = 9,
            DataOra = 10,
            HexSoglia = 11,
            Uint32 = 12,
            Int64 = 13,
            IndirizzoLogico = 14,
            Numero_Service_Enable = 15,
            OreMinute = 16,
            CodeNumero = 17
        }

        [Serializable]
        public enum FunzioniTastoFx
        {
            Nessuno = 0,
            ScenarioInserimento = 1,
            Allarme = 2,
            Comando = 3,
            AttivaUscita = 4,
            DisattivaUscita = 5,
            BasculaUscita = 6,
            Macro = 7,
            CommandiURL = 8,
            AzioneSuZona = 9
        }

        //*****************************
        //INIZIO UTENTI, INSTALLATORI, CHIAVI
        //*****************************

        [Serializable]
        public enum TipoUtente
        {
            Utente1 = 1,
            Utente2 = 2,
            Utente3 = 3,
            Utente4 = 4,
            Ronda = 5,
            Installatore1 = 6,
            Installatore2 = 7,
            Master = 8,
            Produttore = 9
        }

        [Serializable]
        public enum TipoAzioneUtente
        {
            ResetUtente = 1,
            ResetInstallatore = 2,

            InserimentoNuovoCodiceUtente = 3,
            InserimentoNuovoCodiceInstallatore = 4,

            EliminaInstallatore = 5,
            //this assigne number is associated to idfunction in function list
            AddUsers = 15,
            ChangeOwnCode = 16,
            ChangeOtherUserCode = 17,
            EliminaUtente = 18,
        }

        //*****************************
        //FINE UTENTI, INSTALLATORI, CHIAVI
        //*****************************

        [Serializable]
        public enum TableType : ushort
        {
            Service = 0,
            SystemTimers = 1,
            HolidayGroups = 2,
            TimePrograms = 3,
            User = 4,
            Remotes = 5,
            Keyfobs = 6,
            Installer = 7,
            UserProfile = 8,
            RF_Zone = 9,
            WiredZone = 10,
            GlobalSettingsDetector = 11,
            Keypads = 12,
            RF_Output = 13,
            WiredOutput = 14,
            CCTVDevices = 15,
            Aree = 16,
            ArcAndPhonebook = 17,
            ArmDisarmMenu = 18,
            ArmingPrograms = 19,
            GeneralOptions = 20,
            SystemParameter = 21,

            EventReportSettings = 22,
            EventReportingOption = 23,
            AudioOptions = 24,
            TcpIpSettings = 25,

            ParametriDiSistema = 26,
            EventLog = 27,
            Macro = 28,
            LastEvent = 29,

            MessageVoice = 30,
            EventsMap = 31,

            Options_3G = 32,
            CloudOptions = 33,
            AccessPointSettings = 34,

            GlobalSettingsOutput = 35,

            ToolsTable = 37,
            UpDownloadOptions = 39,

            Repeater = 40,

            PanelAssociationCloudAccount = 41,

            CloudUsers = 133,
            Ranges_HolidayGroups = 102,
            TimeSlot_TimeProgram = 103,
            AreaArmingPrograms = 119,
            MacroAction = 128,
            TimeSlot_AreasTimeProgram = 1003,

            Nessuno = 65535,
            //add new table for wifree
            URLCommands = 48,
        }

        [Serializable]
        public enum TransmissionType
        {
            Send = 0,
            Receive = 1,
            Nessuna = 1000
        }


        [Serializable]
        public enum TipoDescrizioni
        {
            Descrizioni = 0,
            Gsm = 1,
            MappaContactId = 2
        }

        [Serializable]
        public enum ComunicationType
        {
            Serial = 0,
            TCPIP = 1,
            MQTT = 2,
            Null = 3
        }

        [Serializable]
        public enum Agenti
        {
            AGENTE_NESSUNO,
            //-->> espansioni da bus I/O
            AGENTE_CENTRALE = 0x01,
            AGENTE_ESP_4IN_1O = 0x02,
            AGENTE_ESP_4O = 0x03,
            AGENTE_ESP_8IO = 0x04,
            //-->> espansioni da bus di comunicazione esterna al bus
            //     e dispositivi di segnalazione
            AGENTE_CON_RADIO = 0x10,
            AGENTE_GSM_BUS = 0x11,
            AGENTE_SIRENA = 0x12,
            // Dispositivi da bus particolari
            AGENTE_ALIMENTATORE = 0x20,
            AGENTE_ISOLATORE_BUS = 0x21,
            AGENTE_PAL_IP = 0x22,
            AGENTE_D_BRIDGE = 0x23,
            //-->> Dispositivi di controllo da bus

            AGENTE_TASTIERA = 0x30,
            AGENTE_SAFETOUCH = 0x31,
            AGENTE_PLANUX = 0x32,
            AGENTE_RFID = 0x33,
            AGENTE_IMPRONTE_D = 0x34,
            AGENTE_MINITOUCH = 0x35,
            AGENTE_APP = 0x36,
            AGENTE_PC_TOUCH = 0x37,
            AGENTE_ICONA_VIP = 0x38,
            AGENTE_ICONA_SBC = 0x39,
            //--> Agenti di controllo non da bus

            AGENTE_IP_CENTRALE = 0x40,
            AGENTE_IP_WEB,
            AGENTE_IP_PC,
            AGENTE_USB,
            AGENTE_MODEM_PSTN,
            AGENTE_MODEM_GSM,
            AGENTE_MENU_VOCALE_PSTN,
            AGENTE_MENU_VOCALE_GSM,
            AGENTE_GSM_SMS,
            AGENTE_DOMOTICA,
            //--> Altri agenti
            AGENTE_ZONA_CBL,
            AGENTE_CHIAVE,
            AGENTE_AREE,
            AGENTE_RADIO_CMD,
            AGENTE_UTENTE,
            //AGENTE_GRUPPI,
            //AGENTE_SISTEMA,
            AGENTE_TIMER,
            AGENTE_INS_AUTOMATICO,
            AGENTE_USCITA,
            AGENTE_AGENDA_TELEFONICA,
            AGENTE_AGENDA_CONTACT_ID
        }

        [Serializable]
        public enum LoginLevel
        {
            Uno = 1,
            Due = 2,
            Tre = 3,
            Quattro = 4
        }

        [Serializable]
        public enum EventGroups
        {
            Alarms = 1,
            Tamper = 2,
            ControlPanelMainsFault = 3,
            ControlPanelBatteryFault = 4,
            DevicesBatteryFaults = 5,
            SystemFaults = 6,
            TotalArm = 7,
            PartialArm = 8,
            Disarm = 9,
            ForcedArm = 10,
            TechnicalProgramming = 11,
            SystemOperations = 12,
            ZoneBypassUnbypass = 13
        }

        public enum LoginStatus
        {
            AZIONE_ESEGUITA = 0,
            //	AZIONE_CONSENTITA = 0,
            //	UTENTE_AUTORIZZATO = 0,
            AZIONE_RICHIEDE_CODICE,
            AZIONE_INS_BLOCCATA,
            AZIONE_INS_BLOCCATA_L2,
            AZIONE_INS_BLOCCATA_L3,
            AZIONE_INS_BLOCCATA_TOT,
            AZIONE_INS_BLOCCATA_P1,
            AZIONE_INS_BLOCCATA_P2,
            UTENTE_SCONOSCIUTO,
            INSTALLATORE_NON_AUTORIZZATO,
            UTENTE_NON_AUTORIZZATO,
            UTENTE_NON_AUTORIZZATO_INS,
            UTENTE_NON_AUTORIZZATO_DISINS,
            UTENTE_NON_AUTORIZZATO_INSIND,
            UTENTE_NON_AUTORIZZATO_FORZ,
            UTENTE_NON_AUTORIZZATO_ON_DEV,
            UTENTE_NON_AUTORIZZATO_ON_AREE,
            UTENTE_TIMER_OFF,
            UTENTE_OPR_OVERFLOW,
            HAI_VINTO_UNA_CENTRALE,
            KEY_NON_VALIDA,
            AZIONE_INS_SCONOSCIUTA,
            DISPOSITIVO_SCONOSCIUTO,
            AZIONE_USCITA_ASSENTE,
            AZIONE_ZONA_ASSENTE,
            AZIONE_ZONA_NON_ESCLUDIBILE,
            AZIONE_ZONA_NON_ISOLABILE,
            AZIONE_ERRORE_DISPOSITIVO,
            PROGRAMMAZIONE_TECNICA,
            UPGRADE_ERROR,
            ERRORE_AREE_INSERITE,
            CODA_PIENA,
            DISPOSITIVO_BLOCCATO,
            ESITO_AZIONE_MAX, //NB: Item da lasciare in coda per permettere il controllo di congruenza con il vettore id_str_act_res_type
            INSTALLER_NOT_AUTORIZED_SYSTEM_ARMED = 36
        }

        public enum TipoTrasferimento
        {
            READ = 0,
            WRITE = 1
        }


        public enum TipoPing
        {
            StatoFirmwareProg = 0,
            StatoFirmwareBoot = 1
        }

        public enum RispostaPeriferica
        {
            ACK = 0,
            NACK = 1
        }

        public enum eDeviceTypes
        {
            Unidentified,
            PlanuxVip,
            MaestroVip,
            PowercomVip,
            EasycomVip,
            TelecameraPalIp,
            CpsVip,
            NumberOfItems
        }

        public enum SAPI_Versions
        {
            Nessuna = 0,
            SAPI_4 = 4,
            SAPI_5 = 5,
            MSP = 11,
            SAPI_G = 255
        }


        public enum ImportExportAction
        {
            Import = 0,
            Export = 1
        }

        public enum Lingue
        {
            Inglese = 1,
            Italiano = 2,
            Francese = 3,
            Olandese = 4,
            Spagnolo = 5,
            German = 6,
            Portuguese = 7,
            Russian = 8,
            Turkish = 9
        }

        public enum FirmwareValidity
        {
            Sconosciuto = 0,
            Valido = 1,
            HidNonValido = 2,
            HCodeVersionNonValido = 3,
            Errore = 255
        }

        /// Identifier of the params configuration
        public enum ProjectsDefault
        {
            NORMA, ///< Standards defaut
            BASE   ///< Simple default
        }


        public enum WIFI_TypeCommand
        {
            Scan = 0,
            Connect = 1,
            Disconnect = 2,
            GetSSID = 3,
            GetIPInfos = 4,
            GetModeWIFI = 5,
            ConnectToHiddenWIFI = 6
        }
        public enum ParamtersOfSpecificSettingsSensor
        {
            Led,
            DeviceDetectorDisarm,
            BeaconSkipNumber,
            SupervisionTimeInterval,
            TamperReed,
            MagneticInput,
            FastExternal2CfgWin,
            FastExternal2CfgPulse,
            External1Cfg,
            External2Cfg,
            AspMode,
            PetImmuneFilter,
            PulseFilterConf,
            PirSensorSignalGain,
            ExternalInput,
            InternalMagneticInput,
            ShockVibrationSensor,
            FallSensor,
            FastExternal1CfgWin,
            FastExternal1CfgPulse,
            Smoke,
            Heat,
            CameraEnable,
            ContrastEnhancement,
            SharpnessEnhancement,
            DifferentialJpeg,
            JpegMode,
            NumPictureInOneSet,
            PictureQualityParamet,
            HoldOffTime,
            PictureColorResolution,
            PictureRate,
            GBD,
            GBD_AutoGainControl,
            ActionOnFire,
            ActionOnArm,
            ActionOnDisarm,
            ActionOnFlash,
            MaintenanceMode,
            ActivationTimeOut,
            DisactivationTimeout,
            SounderLoudness,
            PulseOnTime,
            PulseOffTime
        }
        public enum RFSpecificDeviceType_Teletek
        {
            //Detectors
            SPEC_DEV_INIT = 0x00,           /*!< Default Specific device type: Not set. */

            //EXPANDER_DEVICE = 0X20,
            REPEATER_DEVICE = 0X20,
            KEYPAD_DEVICE = 0X30,

            SIREN_DEVICE_INDOOR = 0x40,
            SIREN_DEVICE_OUTDOOR = 0x41,
            OUTPUT_DEVICE = 0X45,

            MAG_DETECTOR = 0X50, // Magnetic MAG1, MAG2, MAG Compact
            MAG1_DETECTOR = 0x51,// Magnetic MAG1, MAG2, MAG Compact
            MAG2_DETECTOR = 0x52,// Magnetic MAG1, MAG2, MAG Compact

            UNIVERSAL = 0x53, // Universal RF

            GLASS_BREAK_DETECTOR = 0X55,//GBD Glass Break detector
            VIBRATION_DETECTOR = 0X56, // Magnetic Attack
            PIR_DETECTOR = 0X60,//PIR
            PIR_CAM_DETECTOR = 0X61,// Camera PIR detector
            PIR_EXTERNAL = 0x62,
            PIR_EXTERNAL_MICROWAVE = 0x63,

            RMT_2_WAY_DETECTOR = 0x70,
            RMT_1_WAY_1_BUTTON_DETECTOR = 0x71,
            RMT_1_WAY_2_BUTTON_DETECTOR = 0x72,
            RMT_1_WAY_4_BUTTON_DETECTOR = 0x74,
            RMT_PANIC = 0x78,

            RMT_2_WAY_DETECTOR_REPEATER_1 = 0xE1,
            RMT_2_WAY_DETECTOR_REPEATER_2 = 0xE2,
            RMT_2_WAY_DETECTOR_REPEATER_3 = 0xE3,
            RMT_2_WAY_DETECTOR_REPEATER_4 = 0xE4,

            RMT_PANIC_REPEATER_1 = 0xE5,
            RMT_PANIC_REPEATER_2 = 0xE6,
            RMT_PANIC_REPEATER_3 = 0xE7,
            RMT_PANIC_REPEATER_4 = 0xE8,

            SMOKE_DETECTOR = 0X80, // Smoke sensor
            FLOOD_DETECTOR = 0X81,//Flood/TTE Magnetic
            GAS_DETECTOR = 0X82
        }


        [Serializable]
        public enum AlarmSeviceEnableDevice
        {
            ENABLE_NOT_USED = 0,
            ENABLE,
            DISABLE
        }

        [Serializable]
        public enum ZoneAuxiliaryInputsFlag
        {
            AUX_ENABLE_NOT_USED = 0,
            AUX_ENABLE_B,
            AUX_ENABLE_BC,
            AUX_ENABLE_LAST
        }

        public enum RF_ZONE_TYPE_INDEX
        {
            RF_ZONE_NOT_USED_INDEX = 0, /* Not used */
            RF_ZONE_ALARM_INDEX,
            RF_ZONE_ENTRY_EXIT_1_INDEX,
            RF_ZONE_ENTRY_EXIT_2_INDEX,
            RF_ZONE_ACCESS_INDEX,
            RF_ZONE_ENTRY_DOOR_INDEX,
            RF_ZONE_LIGHT_1_INDEX,
            RF_ZONE_LIGHT_2_INDEX,
            RF_ZONE_ROLLER_SH_UP_INDEX,
            RF_ZONE_ROLLER_SH_DOWN_INDEX,
            RF_ZONE_MACRO_INDEX,
            RF_ZONE_DAY_LIGHT_INDEX,
            RF_ZONE_FIRE_DOOR_INDEX,
            RF_ZONE_ARM_INDEX,
            RF_ZONE_AUXILIARY_INDEX,
            RF_ZONE_24HR_INDEX,
            RF_ZONE_PANIC_INDEX,
            RF_ZONE_FIRE_INDEX,
            RF_ZONE_MEDICAL_INDEX,
            RF_ZONE_GAS_INDEX,
            RF_ZONE_FLOOD_INDEX,
            RF_ZONE_ENVIRONMENTAL_INDEX,
            RF_ZONE_THERMOSTAT_INDEX,
            RF_ZONE_NO_MOTION_INDEX,
            RF_ZONE_FAULT_INDEX
        }

        public enum RF_OUTPUT_TYPE_INDEX
        {
            OUTPUT_NOT_USED = 0,
            OUTPUT_EXT_BELL = 1,
            OUTPUT_INT_BELL,
            OUTPUT_FULL_ARM,
            OUTPUT_PART_ARM_1,
            OUTPUT_PART_ARM_2,
            OUTPUT_ARM_STATUS,
            OUTPUT_MAIN_POWER_FAILURE,
            OUTPUT_LOW_BATTERY,
            OUTPUT_TAMPER,
            OUTPUT_GSM_TROUBLE,
            OUTPUT_SYSTEM_TROUBLE,
            OUTPUT_SUPERVISION,
            OUTPUT_MEDICAL,
            OUTPUT_DURESS,
            OUTPUT_FIRE,
            OUTPUT_PANIC,
            OUTPUT_BURGLARY,
            OUTPUT_ZONE_STATUS,
            OUTPUT_REMOTE_1,
            OUTPUT_REMOTE_2,
            OUTPUT_NO_MOTION,
            OUTPUT_LIGHT_1,
            OUTPUT_LIGHT_2,
            OUTPUT_ROLLER_SH_UP,
            OUTPUT_ROLLER_SH_DOWN,
            OUTPUT_DEFAULT_SETTING,
            OUTPUT_DEL_RF_ZONE,
        }

        public enum RC_Cloud_SubCommand
        {
            // Pin request subcommands
            CMD_PIN_REQ = 0x00,
            CMD_PIN_SEND = 0x01,
            CMD_PIN_ACK = 0x02,
            // CloudNext : In order to associate new users, a new sub-command has been implemented since the request must include the role for whom OTP is generated.
            CMD_PIN_REQ_ROLE = 0x03,
            // Email write on-line subcommands
            CMD_WR_EMAIL_ONLINE = 0x10,
            CMD_WR_EMAIL_ONLINE_ACK = 0x11,
            CMD_WR_EMAIL_ONLINE_ACK_ACK = 0x12,
            // Email write off-line subcommands
            CMD_WR_EMAIL_OFFLINE = 0x13,
            CMD_WR_EMAIL_OFFLINE_ACK = 0x14,
            CMD_WR_EMAIL_OFFLINE_ACK_ACK = 0x15,
            // Request of available devices list subcommand
            CMD_LIST_AV_DEV_REQ = 0x20,
            // Request installer email delete
            CMD_DEL_INST_EMAIL = 0x30,
            // CloudNext : In order to disassociate active users, a new sub-command has been implemented.
            CMD_DEL_USER = 0x31,
            // CloudNext : In order to remove user name.
            CMD_DEL_USER_EMAIL = 0x32,
            CMD_DEL_USER_EMAIL_ACK = 0x33,
            CMD_DEL_USER_EMAIL_ACK_ACK = 0x34,
            // Request download config
            CMD_DOWNLOAD = 0x40,
            CMD_DOWNLOAD_ACK = 0x41,
            CMD_DOWNLOAD_ACK_ACK = 0x42,
            // Request upload config
            CMD_UPLOAD = 0x43,
            CMD_UPLOAD_ACK = 0x44,
            CMD_UPLOAD_ACK_ACK = 0x45,
            //Account association off-line subcommands
            CMD_WR_EMAIL_OFFLINE_V2 = 0x50,
            CMD_WR_EMAIL_OFFLINE_V2_ASYN_ACK = 0x51,
            CMD_WR_EMAIL_OFFLINE_V2_ASYN_ACK_ACK = 0x52
        }

        public enum AudioResource
        {
            DefaultMessage,
            UseMicrophone,
            TextToSpeech
        }
        public enum SystemParameter
        {

            SYSTEM_PARAM_INSTALLATION_NAME = 5

        }
        public enum Tools
        {
            MacAddress = 0,
            EnableWathdog = 1,
            EnableSSH = 2,
            ChannelNumber = 3,
            TxPower = 4,
            EnableSdDebug = 5,
            WiFiMacAddr,
            RfModelId,
            DeviceInfoStatus,
            SdRecordEnable,
            ControlPanelId32,
            CpProductCode,
            RfModuleProductCode,
            CpKeypadProductCode,
            GsmProductCode,
            GsmImei,
            WizardCloudEnable
        }

        public enum UserRoles
        {
            ROLE_NOT_USED = 0,
            ROLE_USER,
            ROLE_INSTALLER,
            ROLE_LAST
        }

        public enum StatusCommand
        {
            Reset = 0,
            RequestSent = 1,
            Ack = 2,
            ActionOccurred = 3
        }

        public enum ModeWIFI
        {
            NotConnected = 0,
            Client,
            AccesPoint
        }
    }


