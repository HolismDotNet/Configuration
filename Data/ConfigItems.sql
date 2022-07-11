insert ignore into Configuration.ConfigItems
(
    ConfigTypeId,
    Name,
    Description,
    `Key`
)
values
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'Text'
    ),
    'Payment Gateway Code',
    'The code that bank gave you for the identification of your online shop',
    'PaymentGatewayCode'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'NaturalNumber'
    ),
    'Max Age',
    'At what age a user can no longer use your services?',
    'MaxAge'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'Integer'
    ),
    'Miminum Allowed Score',
    'The score at which a user would be banned from continuing the usage',
    'MinimumAllowedScore'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'RealNumber'
    ),
    'Loyalty Return Coefficient',
    'How much of each purchase are you willing to return to the customer?',
    'LoyaltyReturnCoefficient'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'Boolean'
    ),
    'Send Login SMS',
    'Should system send SMS for logins?',
    'SendLoginSms'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'NullableBoolean'
    ),
    'Has Discount',
    'Specifies the discount status of the product',
    'HasDiscount'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'Color'
    ),
    'Logo Color',
    'The logo color for each invoide you send to your customers',
    'LogoColor'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'SingleChoice'
    ),
    'Default City',
    'What city should be chosen as the default city',
    'DefaultCity'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'MultipleChoice'
    ),
    'Home Page Sections',
    'Which sections do you want to show in the home page?',
    'HomePageSections'
),
(
    (
        select Id
        from Configuration.ConfigTypes 
        where `Key` = 'Percent'
    ),
    'VAT Percent',
    'How much your tax organization gets from your customers?',
    'VatPercent'
);