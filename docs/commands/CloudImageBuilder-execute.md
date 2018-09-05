# CloudImageBuilder Execute

## Name

`CloudImageBuilder execute` - Searches for snowflakes in the sun

## Synopsis

```
CloudImageBuilder execute [-l|--verbosity] [-v|--vault] [-c|--client-id] [-p|--client-secret]
```

## Description

The `CloudImageBuilder execute` command searches the void for snowflakes in the sun. The result of this command are some snowflakes. If a client id, client secret and vault was specified, then the settings will be read from the configuration.

## Arguments

This command has no arguments

## Options

`-l|--verbosity {Trace|Debug|Information|Warning|Error|Critical|None}`

Defines the verbosity of the CloudImageBuilder outputs. The default value is Information.

`-v|--vault`

The name of the vault where settings are stored.

`-c|--client-id`

The client id used to access the vault.

`-d|--client-secret`

The client secret used to access the vault.

## Examples

Searches for snowflakes in the sun:

```
CloudImageBuilder execute
```

Searches for snowflakes in the sun, printing debug messages

```
CloudImageBuilder execute --verbosity debug
```
