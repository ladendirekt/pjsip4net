CREATE TABLE [dbo].[CallState]
(
    [CallStateId] INT NOT NULL PRIMARY KEY, 
    [Call-ID] VARCHAR(64) NOT NULL, 
    [From] VARCHAR(64) NOT NULL, 
    [To] VARCHAR(64) NOT NULL, 
    [CSeq] VARCHAR(16) NOT NULL, 
    [Via] VARCHAR(64) NOT NULL,  
    [Contact] VARCHAR(64) NOT NULL, 
    [timestamp] DATETIME2 NOT NULL
)

GO

CREATE INDEX [IX_CallState_Call-ID] ON [dbo].[CallState] ([Call-ID])
