namespace pjsip4net.Core.Data
{
    public enum SipStatusCode
    {
        /// Trying -> 100
        Trying = 100,

        /// Ringing -> 180
        Ringing = 180,

        /// CallBeingForwarded -> 181
        CallBeingForwarded = 181,

        /// Queued -> 182
        Queued = 182,

        /// Progress -> 183
        Progress = 183,

        /// Ok -> 200
        Ok = 200,

        /// Accepted -> 202
        Accepted = 202,

        /// MultipleChoices -> 300
        MultipleChoices = 300,

        /// MovedPermanently -> 301
        MovedPermanently = 301,

        /// MovedTemporarily -> 302
        MovedTemporarily = 302,

        /// UseProxy -> 305
        UseProxy = 305,

        /// AlternativeService -> 380
        AlternativeService = 380,

        /// BadRequest -> 400
        BadRequest = 400,

        /// Unauthorized -> 401
        Unauthorized = 401,

        /// PaymentRequired -> 402
        PaymentRequired = 402,

        /// Forbidden -> 403
        Forbidden = 403,

        /// NotFound -> 404
        NotFound = 404,

        /// MethodNotAllowed -> 405
        MethodNotAllowed = 405,

        /// NotAcceptable -> 406
        NotAcceptable = 406,

        /// ProxyAuthenticationRequired -> 407
        ProxyAuthenticationRequired = 407,

        /// RequestTimeout -> 408
        RequestTimeout = 408,

        /// Gone -> 410
        Gone = 410,

        /// RequestEntityTooLarge -> 413
        RequestEntityTooLarge = 413,

        /// RequestUriTooLong -> 414
        RequestUriTooLong = 414,

        /// UnsupportedMediaType -> 415
        UnsupportedMediaType = 415,

        /// UnsupportedUriScheme -> 416
        UnsupportedUriScheme = 416,

        /// BadExtension -> 420
        BadExtension = 420,

        /// ExtensionRequired -> 421
        ExtensionRequired = 421,

        /// SessionTimerTooSmall -> 422
        SessionTimerTooSmall = 422,

        /// IntervalTooBrief -> 423
        IntervalTooBrief = 423,

        /// TemporarilyUnavailable -> 480
        TemporarilyUnavailable = 480,

        /// CallTsxDoesNotExist -> 481
        CallTsxDoesNotExist = 481,

        /// LoopDetected -> 482
        LoopDetected = 482,

        /// TooManyHops -> 483
        TooManyHops = 483,

        /// AddressIncomplete -> 484
        AddressIncomplete = 484,

        /// PjsipAcAmbiguous -> 485
        PjsipAcAmbiguous = 485,

        /// BusyHere -> 486
        BusyHere = 486,

        /// RequestTerminated -> 487
        RequestTerminated = 487,

        /// NotAcceptableHere -> 488
        NotAcceptableHere = 488,

        /// BadEvent -> 489
        BadEvent = 489,

        /// RequestUpdated -> 490
        RequestUpdated = 490,

        /// RequestPending -> 491
        RequestPending = 491,

        /// Undecipherable -> 493
        Undecipherable = 493,

        /// InternalServerError -> 500
        InternalServerError = 500,

        /// NotImplemented -> 501
        NotImplemented = 501,

        /// BadGateway -> 502
        BadGateway = 502,

        /// ServiceUnavailable -> 503
        ServiceUnavailable = 503,

        /// ServerTimeout -> 504
        ServerTimeout = 504,

        /// VersionNotSupported -> 505
        VersionNotSupported = 505,

        /// MessageTooLarge -> 513
        MessageTooLarge = 513,

        /// PreconditionFailure -> 580
        PreconditionFailure = 580,

        /// BusyEverywhere -> 600
        BusyEverywhere = 600,

        /// Decline -> 603
        Decline = 603,

        /// DoesNotExistAnywhere -> 604
        DoesNotExistAnywhere = 604,

        /// NotAcceptableAnywhere -> 606
        NotAcceptableAnywhere = 606,

        /// TsxTimeout -> RequestTimeout
        TsxTimeout = RequestTimeout,

        /// TsxTransportError -> ServiceUnavailable
        TsxTransportError = ServiceUnavailable,
    }
}